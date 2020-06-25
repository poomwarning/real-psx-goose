using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickingcard : MonoBehaviour
{
    public GameObject goose;
    public GameObject lv4cut;
    public AudioSource BGsong;
    public GameObject doortext;
    public GameObject roomtext;
    public GameObject stair;
    public GameObject stairbroken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="PlayerL")
        {
            BGsong.Stop();
            goose.SetActive(true);
            lv4cut.SetActive(true);
            stair.SetActive(false);
            stairbroken.SetActive(true);
            Destroy(doortext);
            Destroy(roomtext);
            Destroy(gameObject);
        }    
    }
}
