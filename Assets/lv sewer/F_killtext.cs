using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_killtext : MonoBehaviour
{
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
       text.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            
            text.SetActive(false);
            
        }
    }
}
