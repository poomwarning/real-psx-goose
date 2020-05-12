using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement_test : MonoBehaviour
{
    public CharacterController controller;
    public Level_Ctrl lv_ctrl;
    public float speed = 12f;
    [SerializeField]
    private GameObject key;
    private bool IsDoorsucc = false;

    private bool Locked_door = true;
    private bool AreDoorSUCC = false;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(IsDoorsucc && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("yoink");
            lv_ctrl.Scene_chager3();
        }

        if(AreDoorSUCC && Input.GetKeyDown(KeyCode.E) && Locked_door == false)
        {
            Debug.Log("yote");
            lv_ctrl.Scene_chager3();
        }
        
        if(Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.DeleteKey("Key1");
            Debug.Log("yeet");
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Door1")
        {
            IsDoorsucc = true;            
        }

        if(other.gameObject.tag == "Key")
        {
            PlayerPrefs.SetInt("Key1",1);
            Locked_door = false;
            Destroy(key); 
            
        }

        if(other.gameObject.tag == "Door2")
        {
            AreDoorSUCC = true;
        }
    }

    
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Door1")
        {
            IsDoorsucc = false;            
        }

        if(other.gameObject.tag == "Door2")
        {
            AreDoorSUCC = false;
        }
    }
    void Start() 
    {
        if(PlayerPrefs.GetInt("Key1") == 1)
        {
            Locked_door = false;
        }
    }
}
