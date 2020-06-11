using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventladder : MonoBehaviour
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
        yield return new WaitForSeconds(3.8f);
        openhatch.Play();
        yield return new WaitForSeconds(2.0f);
        openhatch.Play();
        yield return new WaitForSeconds(2.0f);
        openhatch.Play();
        yield return new WaitForSeconds(2.0f);
        openhatch.Play();
        darkfade.GetComponent<Animation>().Play("whTdark");
         yield return new WaitForSeconds(3.0f);
        Application.LoadLevel(levelToLoad);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
