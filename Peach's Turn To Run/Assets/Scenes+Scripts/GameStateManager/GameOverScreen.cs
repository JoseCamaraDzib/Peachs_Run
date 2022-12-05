using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //Coded by Jose Camara Dzib
    public static bool GameIsOver = false;

    public GameObject gameOverUI;
    public GameObject scoreUI;

    [SerializeField]
    private GameManager GM;

    [SerializeField]
    private PlayerController PC;


    public void EndGame()
    {
        gameOverUI.SetActive(true);
        scoreUI.SetActive(false);
    }

    public void Menu()
    {
        GM.BackToMain();
    }

    public void Restart()
    {
        GM.PlayGame();
    }
}