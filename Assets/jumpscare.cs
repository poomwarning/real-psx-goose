using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscare : MonoBehaviour
{
    public GameObject jumpscarepoop;
    public AudioSource jumpscaresound;

     private void Start() 
    {
        jumpscarepoop.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            StartCoroutine(jumpevent());
        }
    }
    IEnumerator jumpevent()
    {
        jumpscaresound.Play();
        jumpscarepoop.SetActive(true);
         yield return new WaitForSeconds(0.3f);
        jumpscarepoop.SetActive(false);
        Destroy(gameObject);
    }
}
