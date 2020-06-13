using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warp : MonoBehaviour
{
    public Transform player;
    public Transform waypoint;
    public Animator goairvent;

    public GameObject disablewalk;
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
     if(other.gameObject.tag=="Player")
     {
         StartCoroutine(fadewarp());
     }   
    }
    IEnumerator fadewarp ()
    {
        disablewalk.GetComponent<FPSMOVEMENT>().enabled = false;
        goairvent.SetBool("airvent",true);
        yield return new WaitForSeconds(9f);
        player.transform.position = waypoint.transform.position;
        disablewalk.GetComponent<FPSMOVEMENT>().enabled = true;
    }
    
}
