using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmanager : MonoBehaviour
{
    public AudioSource backgroundmusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pausemenu.GameIsPaused)
        {
            backgroundmusic.pitch*=.5f;
        }
        else
        {
             backgroundmusic.pitch=1f;
        }
    }
}
