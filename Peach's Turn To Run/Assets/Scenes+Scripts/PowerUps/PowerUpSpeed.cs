using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : PowerUpBase
{
    [SerializeField]
    private float speedBoost;

    [SerializeField]
    private float boostTime;

    private float startTime;
    private PlayerController m_Player;

    public override void Apply(PlayerController player)
    {
        startTime = Time.time;
        m_Player = player;
        m_Player.IncreaseSpeed(speedBoost);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - startTime > boostTime)
        {
            m_Player.IncreaseSpeed(-speedBoost);
            Destroy(gameObject);
        }
    }
}
