using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowbarpick : MonoBehaviour
{
    public GameObject crowbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnTriggerStay(Collider other) 
     {
        crowbar.SetActive(true);
        Destroy(gameObject);
    }
}
