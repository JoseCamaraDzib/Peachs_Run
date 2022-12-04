using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //Coded by José Cámara Dzib
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    [SerializeField]
    private GameManager GM;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
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
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
        GM.PlayGame();
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Menu()
    {
        GM.BackToMain();
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
