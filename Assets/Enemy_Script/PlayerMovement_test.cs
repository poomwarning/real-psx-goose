using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement_test : MonoBehaviour
{
    public CharacterController controller;
    public Level_Ctrl lv_ctrl;
    public float speed = 12f;
    [SerializeField]
    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) 
    {
        
    }

    
    void OnTriggerExit(Collider other)
    {
        
    }
    void Start() 
    {
        
    }
}
