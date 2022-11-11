using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observers 
{
    public interface Suscribers
    {
        void Activate();
    } 
    public abstract class Publisher
    {
        List<Suscribers> _members;

        public Publisher () 
        {
            _members = new List<Suscribers>();
        }

        public void Suscribe (Suscribers s)
        {
            _members.Add(s);
        }
        public void Unsuscribe (Suscribers s)
        {
            _members.Remove(s);
        }

        public void Notify() 
        {
            foreach(Suscribers s in _members)
            {
                s.Activate();
            }
        }

    }
   public class PublisherBolitas : Publisher 
   {
        private static PublisherBolitas _instance;
        
        public PublisherBolitas () : base () {}

        public static PublisherBolitas GetInstance() 
        {
            if(_instance == null )
            {
                _instance = new PublisherBolitas();
            }
            return _instance;
        }
   }

}
