using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    void Start()
    {   
        if(PlayerPrefs.GetInt("Key1") ==  1)
        {
            Destroy(gameObject);
        }
    }
}
