using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorstuck : MonoBehaviour
{
    public Animator doorstuckanim;
    public AudioSource doorstucking;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay(Collider other) 
     {
        if (other.gameObject.tag == "PlayerL")
        {
             if( Input.GetButtonDown("Use"))
             {
                 doorstucking.Play();
                 doorstuckanim.SetBool("doorstuck",true); 
             }
             if( Input.GetButtonUp("Use"))
             {
                 doorstuckanim.SetBool("doorstuck",false); 
             }
           
        }
    }
    void doorstucksound()
    {
        doorstucking.Play();
    }
    void doorclose()
    {
        doorstuckanim.SetBool("doorstuck",false); 
    }
}
