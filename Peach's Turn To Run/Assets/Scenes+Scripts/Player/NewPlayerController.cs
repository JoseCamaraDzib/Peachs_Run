using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour
{
    [SerializeField] public float speed;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }
}