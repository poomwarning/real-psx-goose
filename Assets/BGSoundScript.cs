using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGSoundScript : MonoBehaviour
{
    public static bool loadDone;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //private  BGSoundScript instance = null;
    //public  BGSoundScript Instance
    //{
   //     get { return instance; }
    //}

    void Awake()
    {
       /* if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }*/
        DontDestroyOnLoad(this.gameObject);
    }
     private void Update() 
     {
        if(loadDone==true)
        {
            Destroy(this.gameObject);
        }
    }
    
}