using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*public class Obstacles : MonoBehaviour

public class ObstaclesSpawner: MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate;
    public float minHeight;
    public float maxHeight;

    // Start is called before the first frame update
    void Start()
    {
        //The first obstacle
        spawnRate = 1f;
        minHeight = -3f;
        maxHeight = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}




   private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject obstacles = Instantiate(prefab, transform.position, Quaternion.identity);
        obstacles.transform.position += Vector3.right * Random.Range(minHeight, maxHeight);
    }*/
