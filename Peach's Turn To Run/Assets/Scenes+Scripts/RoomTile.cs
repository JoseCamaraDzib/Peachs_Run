using UnityEngine;

public class RoomTile : MonoBehaviour
{
    RoomSpawner groundSpawner;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<RoomSpawner>();
    }

    /*private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 10);
    }*/

    void Update()
    {
        
    }
}
