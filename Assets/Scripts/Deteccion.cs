using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mementos;

public class Deteccion : MonoBehaviour
{

    public void OnTriggerEnter(Collider col) 
    {
        if (col.tag == "detectar")
        {
            Debug.Log("Entra a checkpoint");
            CheckPoint cp = new CheckPoint(transform);
            MementoCheckPoints.GetInstance().AddStatus(cp);

        }
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Status s = MementoCheckPoints.GetInstance().GetStatus();
            if(s != null){
                transform.position = new Vector3(s.statusLib["posx"], s.statusLib["posy"], s.statusLib["posz"]);
            }
        }
    }
}
