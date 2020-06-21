using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footevent : MonoBehaviour
{
    public AudioSource foot;
    public AudioSource exhust;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void run()
    {
        foot.Play();
        exhust.Play();
    }
}
