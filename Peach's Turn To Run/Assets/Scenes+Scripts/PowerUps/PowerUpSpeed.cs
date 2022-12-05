using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUpBase
{
    //Coded by Jose Camara Dzib
    [SerializeField]
    private float speedBoost;

    [SerializeField]
    private float boostTime;

    private float startTime;
    private PlayerController thePlayer;

    public override void Apply(PlayerController player)
    {
        startTime = Time.time;
        thePlayer = player;
        thePlayer.IncreaseSpeed(speedBoost);
    }

    //Removes ability after duration
    void Update()
    {
        if (Time.time - startTime > boostTime)
        {
            thePlayer.IncreaseSpeed(-speedBoost);
            Destroy(gameObject);
        }
    }
}
