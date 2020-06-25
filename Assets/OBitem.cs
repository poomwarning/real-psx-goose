using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBitem : MonoBehaviour
{
    public GameObject textblock;
    
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
                 Destroy(textblock);
                 Destroy(gameObject);
             }
         }
    }
}
