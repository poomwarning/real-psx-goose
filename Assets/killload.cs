using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killload : MonoBehaviour
{
    private BGSoundScript bigoof;
    // Start is called before the first frame update
    void Start()
    {
      BGSoundScript.loadDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
