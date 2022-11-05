using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, -10 * Time.deltaTime);

        /*if (transform.position.y(#bottom-of-screen-coordinate))
        {
            transform.position = new Vector3(#bottom-of-screen-y-coordinate+f, transform.position.x)
        }*/
    }
}
