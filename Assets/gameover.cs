using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public GameObject gameoverUI;
    public string levelToMenu;

    public AudioSource argg;

    public static bool GameIsOver = false;

    public string levelToRetry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameIsOver==true)
        {
           OVER();
        }
    }
    void OVER()
    {
        argg.Play();
        Time.timeScale = 0f;
        gameoverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
