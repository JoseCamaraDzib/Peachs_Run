using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleSpawner : MonoBehaviour
{
    public GameObject sphere;
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
        Instantiate(sphere, transform.position, Quaternion.identity);
        //GameObject obstacles = Instantiate(sphere, transform.position, Quaternion.identity);
        // obstacles.transform.position += Vector3.right * Random.Range(minHeight, maxHeight);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        

    }
}

