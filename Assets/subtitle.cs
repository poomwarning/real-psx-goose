﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class subtitle : MonoBehaviour
{
    public GameObject UIObject;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }
     void OnTriggerEnter(Collider other) 
     {
       if(other.tag=="PlayerL")
       {
           UIObject.SetActive(true);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerExit(Collider other) 
     {
         UIObject.SetActive(false);
    }
}
