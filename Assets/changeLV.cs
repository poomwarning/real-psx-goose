using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;


public class changeLV : MonoBehaviour
{
   
    public string levelToLoad;
    // Use this for initialization
    public GameObject fade;

    void Start()
    {
      
    }
    void Update()
    {
     

    }

    // Update is called once per frame
    void  OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PlayerL")
        {
         
            if ( Input.GetButtonDown("Use"))
            {
                
                StartCoroutine(oof());
                
                //Application.LoadLevel(levelToLoad);
            }
        }
    }
    IEnumerator oof()
    {
        fade.GetComponent<Animation>().Play("fadeINsewer");
        yield return new WaitForSeconds(3.5f);
        Application.LoadLevel(levelToLoad);
        
    }

   
}