using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{
    public GameObject endScreen;
    public bool alive = true;
    void Start()
    {
        StartCoroutine(EndSequence());
    }

   IEnumerator EndSequence()
    {
        yield return new WaitUntil(() => alive = false);
        endScreen.SetActive(true);
    }
}
