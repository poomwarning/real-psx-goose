﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleflashlight : MonoBehaviour
{
    public GameObject flashlight ;
    public AudioSource tik;
    int setflash = 1;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
        if(Input.GetKeyDown(KeyCode.F)&&setflash==1)
        {
            tik.Play();
            flashlight.SetActive(true);
            setflash--;
            
        }
         else if(Input.GetKeyDown(KeyCode.F)&&setflash<1)
        {
            tik.Play();
            flashlight.SetActive(false);
            setflash++;
            
        }
        
         
         

    }
}
