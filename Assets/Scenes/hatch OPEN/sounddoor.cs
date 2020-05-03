using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounddoor : MonoBehaviour
{
   public AudioSource openhatch;
   public GameObject hatch;
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
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
