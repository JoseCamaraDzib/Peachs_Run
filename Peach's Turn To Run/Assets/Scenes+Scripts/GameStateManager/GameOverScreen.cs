using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public static bool GameIsOver = false;

    public GameObject gameOverUI;

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
        GM.PlayGame();
    }
}