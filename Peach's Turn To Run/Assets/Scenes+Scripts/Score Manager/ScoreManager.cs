using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float ptspersec;

    public bool scoreinc;

    void Start()
    {
        if(PlayerPrefs.GetFloat("High Score") != null)
        {
            highScoreCount = PlayerPrefs.GetFloat("High Score");
        }
    }

    // Update is called once per frame
    void Update()
    { 
        if(scoreinc)
        {
            scoreCount += ptspersec * Time.deltaTime;
        }

        if(scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.SetFloat("High Score", highScoreCount);
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
    }
}