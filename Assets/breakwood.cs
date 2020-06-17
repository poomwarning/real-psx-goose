using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakwood : MonoBehaviour

{
    public AudioSource woodbroken;
    
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
         if(Input.GetKeyDown(KeyCode.Mouse0)&&boolitem.Pickingcrowbar==true)
         {
             woodbroken.Play();
             Destroy(gameObject);
         }
     }        
    }
    
}
