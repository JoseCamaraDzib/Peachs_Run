using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    //Coded by Jos� C�mara Dzib
    [SerializeField]
    private PowerUpPickup pickUpPrefab;

    public void Start()
    {
        PowerUpPickup instance = Instantiate(pickUpPrefab, transform);
        instance.Init(this);
    }

    public abstract void Apply(PlayerController player);
}
