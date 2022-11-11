using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Observers;

public class Bolita : CustomGameObject, Suscribers
{
    public Bolita  () : base (Resources.Load("Bolita") as GameObject, "Bolita")
    {

    }
    public void Activate(){
        gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.up * 2000);
    }
}
