using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Level_Ctrl : MonoBehaviour
{
    public void Scene_Changer()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Jumpscare_tem");
    }

    public void Scene_chager2()
    {
        SceneManager.LoadScene("Main");
    }

    public void Scene_chager3()
    {
        SceneManager.LoadScene("Next_Level");
    }
    
}
