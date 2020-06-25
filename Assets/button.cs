using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject redlight;
    public GameObject greenlight;
    public Animator doorsilo;
    public GameObject openareaL;
    public GameObject spawner;
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
            if(Input.GetKeyDown(KeyCode.E))
            {
                redlight.SetActive(false);
                greenlight.SetActive(true);
                doorsilo.SetBool("doorsilo",true);
                openareaL.SetActive(true);
                spawner.SetActive(true);
            }
        }    
    }
}
