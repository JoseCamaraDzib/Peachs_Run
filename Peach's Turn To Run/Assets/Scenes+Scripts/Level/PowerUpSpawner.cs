using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    //Coded by Jose Camara Dzib
    public GameObject powerUp;
    public int xPos;
    public int zPos;
    public int zDist;
    public bool creatingPowerUp = false;

    void Update()
    {
        if (creatingPowerUp == false)
        {
            creatingPowerUp = true;
            StartCoroutine(GeneratePowerUp());
        }
    }

    //At same pace as chunk spawning
    IEnumerator GeneratePowerUp()
    {
        yield return new WaitForSeconds(30);
        xPos = Random.Range(-10, 10);
        zPos = Random.Range(-150, 150);
        Instantiate(powerUp, new Vector3(xPos, -2, (zDist + zPos)), Quaternion.identity);
        zDist += 500;
        creatingPowerUp = false;
    }
}
