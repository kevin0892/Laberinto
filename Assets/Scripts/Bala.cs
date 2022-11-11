using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Observers;

public class Bala : CustomGameObject
{
    public Bala  () : base (Resources.Load("Balas") as GameObject, "Balas")
    {
        gameObject.AddComponent<BalaBehaviour>();
    }
    private class BalaBehaviour : MonoBehaviour 
    {
        private void OnCollisionEnter(Collision col) 
        {
            PublisherBolitas pb = PublisherBolitas.GetInstance();
            pb.Notify();
        }
    }
 
 
}
