using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public GameObject roomTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(roomTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(4).transform.position;
    }
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }
}
