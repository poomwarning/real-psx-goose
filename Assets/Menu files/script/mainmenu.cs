﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    IEnumerator playdelay()
    {
        yield return new WaitForSeconds(5f);
    }

    public void play ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void quit ()
    {
        Debug.Log("Quit confirmed");
        Application.Quit();
    }
}
