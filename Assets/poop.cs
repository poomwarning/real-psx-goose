using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class poop : MonoBehaviour
{
    public GameObject UIobject;
    public GameObject Box;
    
    public GameObject car;
    
    
     private void Update() {
       car.transform.position +=  Vector3.forward * (Time.deltaTime*2);
    }
    void Start()
    {
        UIobject.SetActive(false);
    }
     private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player")
        {
            UIobject.SetActive(true);
            
        }
      
    }


     private void OnTriggerExit(Collider other) 
     {
        UIobject.SetActive(false);
    }
}
