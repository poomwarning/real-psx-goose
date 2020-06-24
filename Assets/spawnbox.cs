﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnbox : MonoBehaviour
{
    public GameObject goose;
    public GameObject siloevent;
    public AudioSource bgsound ;
    
    // Start is called before the first frame update
    void Start()
    {
        goose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other) 
     {
         if(other.gameObject.tag=="Player")
         {
             goose.SetActive(true);
             siloevent.SetActive(true);
             bgsound.Stop();
             Destroy(gameObject);
         }
    }
}
