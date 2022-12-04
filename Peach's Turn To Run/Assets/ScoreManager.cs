using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public Text HighScoreText;
    public float ScoreCount;
    public float HighScoreCount;
    public float ptspersec;
    public bool scoreinc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreinc)
        {
            ScoreCount += ptspersec * Time.deltaTime;
        }

        if (ScoreCount > HighScoreCount)
        {
            HighScoreCount = ScoreCount
        }

        ScoreText.text = "Score: " + Mathf.Round(ScoreCount);
        HighScoreText.text = "High Score: " + Mathf.Round(HighScoreText);
    }
}
