using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boolitem : MonoBehaviour
{
    public static bool Pickingcrowbar;
    public Animator crowbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pickingcrowbar = true;
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            crowbar.SetBool("swing",true);
        }
        if(Input.GetKeyUp(KeyCode.Mouse0))
        {
            crowbar.SetBool("swing",false);
        }
    }
}
