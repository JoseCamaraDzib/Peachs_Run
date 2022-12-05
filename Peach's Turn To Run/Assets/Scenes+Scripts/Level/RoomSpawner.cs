using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour //coded by Miranda Ly
{
    public GameObject[] roomTile;
    [SerializeField]public int zPos;
    public bool creatingRoomTile = false;
    public int roomNum;

    void Update()
    {
        if (creatingRoomTile == false)
        {
            creatingRoomTile = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        roomNum = Random.Range(0, 3);
        Instantiate(roomTile[roomNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 100;
        yield return new WaitForSeconds(6);
        creatingRoomTile = false;
    }
}