using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Coded by Veela Agas
    public Text scorevaluetext;
    public float scorevalue = 0f;
    public float pointpersec = 50f;

    void FixedUpdate()
    {
        scorevaluetext.text = ((int)scorevalue).ToString();
        scorevalue += pointpersec * Time.fixedDeltaTime;
    }
}