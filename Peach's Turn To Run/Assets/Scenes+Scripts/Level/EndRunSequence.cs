using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    //Coded by Miranda Ly and José Cámara Dzib
    public GameOverScreen endScreen;
    public bool alive = true;

    public void Start()
    {
        StartCoroutine(EndSequence());
    }

   IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        endScreen.EndGame();
    }
}
