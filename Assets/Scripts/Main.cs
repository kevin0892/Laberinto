using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Observers;

public class Main : MonoBehaviour
{
    public Transform[] _respawns = new Transform[4];
    // Start is called before the first frame update
    void Start()
    {
        Bolita b1 = new Bolita();
        Bolita b2 = new Bolita();
        Bolita b3 = new Bolita();

        b1.transform.position = _respawns[0].position;
        b2.transform.position = _respawns[1].position;
        b3.transform.position = _respawns[2].position;

        Bala bala = new Bala();
        bala.transform.position = _respawns[3].position;

        PublisherBolitas pb = PublisherBolitas.GetInstance();
        pb.Suscribe(b2);
        pb.Suscribe(b1);
        pb.Suscribe(b3);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
