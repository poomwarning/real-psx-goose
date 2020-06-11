using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressEcheck : MonoBehaviour
{
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
        if(other.gameObject.tag=="PlayerL")
        {
            Debug.Log("touching");
            if(Input.GetButtonDown("Use"))
            {
                Debug.Log("E");
               
            }
        }     

    }
}
