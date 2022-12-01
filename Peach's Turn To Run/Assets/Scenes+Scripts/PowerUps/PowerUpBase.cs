using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField]
    public PowerUpPickup inWorldPickUp;

    void Start()
    {
        PowerUpPickup instance = Instantiate(inWorldPickUp, transform);
        instance.Init(this);
    }

    public abstract void Apply(PlayerController player);
}
