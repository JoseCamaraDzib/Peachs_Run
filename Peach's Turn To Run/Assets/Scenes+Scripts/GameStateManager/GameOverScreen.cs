using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //Coded by José Cámara Dzib
    public static bool GameIsOver = false;

    public GameObject gameOverUI;

    private ScoreManager ScoreManager;

    [SerializeField]
    private GameManager GM;

    [SerializeField]
    private PlayerController PC;


    public void EndGame()
    {
        gameOverUI.SetActive(true);
    }

    public void Menu()
    {
        GM.BackToMain();
    }

    public void Restart()
    {
        ScoreManager.scoreinc = false;
        GM.PlayGame();

        ScoreManager.scoreCount = 0;
        ScoreManager.scoreinc = true;
    }
}