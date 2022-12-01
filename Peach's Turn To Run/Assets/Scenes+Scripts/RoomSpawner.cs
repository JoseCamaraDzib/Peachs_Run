using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject[] roomTile;
    public int zPos = 52;
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
        zPos += 52;
        yield return new WaitForSeconds(3);
        creatingRoomTile = false;
    }

    /*public GameObject[] roomTile;
    public float zSpawn = 0;
    public float roomLength = 52;

    private void Start()
    {
        SpawnTile(0);
        SpawnTile(1);
        SpawnTile(2);
    }
    public void SpawnTile(int roomIndex)
    {
        Instantiate(roomTile[roomIndex], transform.forward * zSpawn, transform.rotation);
        zSpawn += roomLength;
    }*/
}