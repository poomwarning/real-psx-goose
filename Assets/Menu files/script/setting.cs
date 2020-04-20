using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setting : MonoBehaviour
{

    public AudioMixer audioMixer;
    public void optionvolume (float volume)
    {
        audioMixer.SetFloat("mainvolume", volume);
    }

    public void fullscreen (bool onfullscreen)
    {
        Screen.fullScreen = onfullscreen;
    }
}
