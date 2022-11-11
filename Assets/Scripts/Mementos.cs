using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mementos
{
    public abstract class Status
    {
        private Dictionary<string, float> _statusDic;

        public Status () 
        {
            _statusDic = new Dictionary<string, float>();
        }
        public Dictionary<string, float> statusLib 
        {
            get {return _statusDic;}
        }

    }

    public class CheckPoint : Status 
    {
        public CheckPoint (Transform t) : base ()
        {
            statusLib.Add("posx", t.position.x);
            statusLib.Add("posy", t.position.y);
            statusLib.Add("posz", t.position.z);
        } 
    }
    public class Memento 
    {
        protected List<Status> _list;
        public Memento()
        {
            _list = new List<Status>();
        }
        public void AddStatus (Status s)
        {
            _list.Add(s);
        }
        public Status GetStatus()
        {
            if (_list.Count > 0)
            {
                Status s = _list[_list.Count -1];
                _list.Remove(s);
                return s;
            } 
            else return null;
        }
    }
    public class MementoCheckPoints : Memento 
    {
        private static MementoCheckPoints _instance;
        private MementoCheckPoints() : base () {}
        public static MementoCheckPoints GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MementoCheckPoints();
            }
            return _instance;
        }
    }
}
