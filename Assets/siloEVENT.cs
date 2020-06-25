using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siloEVENT : MonoBehaviour
{
    public GameObject silo;
    public GameObject siloded;
    public AudioSource breaking;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        silo.SetActive(false);
        siloded.SetActive(true);
        breaking.Play();    
        Destroy(gameObject);
    }
}
