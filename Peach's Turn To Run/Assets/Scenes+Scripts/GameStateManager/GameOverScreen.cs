using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //Coded by Jose Camara Dzib
    public static bool GameIsOver = false;

    public GameObject gameOverUI;

    [SerializeField]
    private ScoreManager SM;

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
        SM.scoreinc = false;
        GM.PlayGame();

        SM.scoreCount = 0;
        SM.scoreinc = true;
    }
}