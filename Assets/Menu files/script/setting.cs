using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setting : MonoBehaviour
{

    public AudioMixer audioMixer_master;
  
  
    public void optionvolume (float volume)
    {
        audioMixer_master.SetFloat("mainvolume", volume);
    }
   

    public void fullscreen (bool onfullscreen)
    {
        Screen.fullScreen = onfullscreen;
    }
}
