using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPickup : MonoBehaviour
{
    //Coded by Jose Camara Dzib
    private PowerUpBase powerUp;

    public void Init(PowerUpBase power)
    {
        powerUp = power;
    }

    private void OnTriggerEnter(Collider collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();
        if (player != null)
        {
            powerUp.Apply(player);
            Destroy(gameObject);
        }
    }
}
