using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeventable : MonoBehaviour
{   
    public AudioSource bang;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void bangsound()
    {
        bang.Play();
    }
}
