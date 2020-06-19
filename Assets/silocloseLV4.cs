using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silocloseLV4 : MonoBehaviour
{
    public Animator doorsilo;
    public GameObject goose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
            
            doorsilo.SetBool("doorsilo",false);
            goose.SetActive(false);
            Destroy(gameObject);
        }    
    }
}
