using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroycar : MonoBehaviour
{
   public GameObject car;
    

   private void ontriggerEnter(Collider other) 
   {
         if(other.tag=="car")
         {
             Destroy(car);
         }
    }

}
