using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tabletrig : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator tablefall;
    void Start()
    {
       // tablefall.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            tablefall.SetBool("doorfall",true);
            Destroy(gameObject);
        }
    }
    
}
