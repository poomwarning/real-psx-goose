﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sounddoor : MonoBehaviour
{
    public string levelToLoad;
   public AudioSource openhatch;
   public GameObject hatch;

   public GameObject darkfade;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(4.0f);
        openhatch.Play();
        hatch.GetComponent<Animation>().Play("hatchopen");
        darkfade.GetComponent<Animation>().Play("whTdark");
         yield return new WaitForSeconds(3.0f);
        //Application.LoadLevel(levelToLoad);
        AsyncOperation  asyncload = SceneManager.LoadSceneAsync(levelToLoad);
        while(!asyncload.isDone)
        {
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
