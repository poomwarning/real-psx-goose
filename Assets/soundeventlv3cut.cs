using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundeventlv3cut : MonoBehaviour
{
    public AudioSource foot;
    public AudioSource hust;
    public AudioSource scream;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void footstep()
    {
        foot.Play();
        hust.Play();

    }
    void screaming()
    {
        scream.Play();
    }
}
