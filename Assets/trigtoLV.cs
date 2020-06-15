using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigtoLV : MonoBehaviour
{
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void  OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PlayerL")
        {
         
           Application.LoadLevel(levelToLoad);
        }
    }
}
