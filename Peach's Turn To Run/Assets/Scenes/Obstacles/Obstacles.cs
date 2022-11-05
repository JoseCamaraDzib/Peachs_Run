using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float speed;
    private float bottomEdge;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        bottomEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).y - 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Move the pillar a little bit each frame
        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.position.y < bottomEdge)
        {
            Destroy(gameObject);
        }
    }
    */
}