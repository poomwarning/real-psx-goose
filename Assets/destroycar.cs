using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroycar : MonoBehaviour
{
   public GameObject oof;
    

   private void ontriggerEnter(Collider other) 
   {
        
             Destroy(oof);
         
    }

}
