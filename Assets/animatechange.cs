using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatechange : MonoBehaviour
{
    public Animator falling;
    // Start is called before the first frame update
    void Start()
    {
          falling.SetBool("fall",true);
    }

    // Update is called once per frame
    void Update()
    {
        falling.SetBool("fall",true);
    }
    
     private void OnCollisionEnter(Collision other) 
     {
      
      
    }
}
