using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    
    private CharacterController _charController;
    private float inputX, inputZ;
    private Vector3 v_movement;
    [SerializeField]
    private float movSpeed = 0.2f;
    private Transform meshPlayer;

    //Checkpoint
    public GameObject checkpoint;

    private void Start()
    {
        
        GameObject tempPlayer = GameObject.FindGameObjectWithTag("Player");
        meshPlayer = tempPlayer.transform;
        _charController = tempPlayer.GetComponent<CharacterController>();
        transform.position = new Vector3(checkpoint.transform.position.x, checkpoint.transform.position.y, checkpoint.transform.position.z);
        tempPlayer.transform.position = new Vector3(checkpoint.transform.position.x, checkpoint.transform.position.y, checkpoint.transform.position.z);
    }

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        v_movement = new Vector3(inputX *movSpeed, 0, inputZ * movSpeed);

        _charController.Move(v_movement);

        if (inputX != 0 || inputZ != 0)
        {
            Vector3 lookDir = new Vector3(v_movement.x, 0, v_movement.z);
            meshPlayer.rotation = Quaternion.LookRotation(lookDir);
        }
        
    }

}