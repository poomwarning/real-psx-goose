using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public Animator _animator;

    public AudioSource dooropen;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void  OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PlayerL")
        {
           Debug.Log("got hand");
            if( Input.GetButtonDown("Use"))
            {
               
                _animator.enabled = true;
              _animator.SetTrigger("opendoor");
            }
           
        }
    }
    
   
}
