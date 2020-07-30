using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    public bool PausedGame = false;
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unPaused;
    
    // MainMenu MainMenuScript;

    // MainMenuScript = gameObject.GetComponent<MainMenu>();

    void Update() 
    {
        //  Debug.Log("update");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Debug.Log("escape");

            if (PausedGame)
            {
                Resume();
                // Debug.Log("resume");
            }
            else
            {
                Pause();
                // Debug.Log("pause");
            }
        }
    }
    public void Pause()
    {
        // Debug.Log("inpause");
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
        paused.TransitionTo(0.01f);
    }
    public void Resume()
    {
        // Debug.Log("inresume");
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
        unPaused.TransitionTo(0.01f);
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Options()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        // MainMenuScript.PreviousScene();
        SceneManager.LoadScene("Options");
    }

}
