using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public AudioSource crash, main;
    public GameObject levelControl;

    void OnCollisionEnter(Collision collisionInfo)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<PlayerController>().enabled = false;
        main.Pause();
        crash.Play();
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
