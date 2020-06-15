using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class pausemenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public string levelToMenu;

    public string levelToRetry;
    
    


    public GameObject pauseMenuUI;
     public GameObject disableMouselook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
           
            if(GameIsPaused)
            {
                
                Resume();
                
            }else
            {
                 Pause();
            }
         
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        disableMouselook.GetComponent<mouselook>().enabled = true;
        AudioListener.pause =false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
         Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        disableMouselook.GetComponent<mouselook>().enabled = false;
        AudioListener.pause =true;
        
    }
    public void loadMenu()
    {
        GameIsPaused = false;
        Debug.Log("Loading Menu...");
        Application.LoadLevel(levelToMenu);
        AudioListener.pause =false;
    } public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void Retry()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        Application.LoadLevel(levelToRetry);
        AudioListener.pause =false;
    }
}
