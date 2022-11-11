using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CustomGameObject {
    
    private GameObject _prefab;
    private GameObject _clone;
    private string _name;
    private int _id;

    public CustomGameObject (GameObject prefab, string name = null) {
        _prefab = prefab;
        _name = name;
        this.InIt();
    }

    public void AddRigidbody(){
        _clone.AddComponent<Rigidbody>();
    }

    private void InIt () {
       _clone = GameObject.Instantiate(_prefab);
       _id = _clone.GetInstanceID();
       ModCloneName();
    }

    private void ModCloneName () {
        if (_name != null) {
            _clone.name = _name;
       }
    }

    public GameObject gameObject {
        get { return _clone; }
    }

    public Transform transform {
        get { return _clone.transform; }
    }

    public string name {
        get { return _name; }
        set { 
            _name = value; 
            ModCloneName();
        }
    }
}
