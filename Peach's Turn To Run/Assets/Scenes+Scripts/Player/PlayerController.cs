using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //done by Miranda Ly
{
    // Start is called before the first frame update
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed; //0 is left, 1 is middle, 2 is right
    public Rigidbody rb;
    public float speed = 5;

    private int desiredLane = 1;

    [SerializeField]
    public float laneDistance = 6;

    [SerializeField]
    public float jumpForce;

    [SerializeField]
    LayerMask groundMask; 

    [SerializeField]
    public float Gravity;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        direction.z = forwardSpeed;

        direction.y += Gravity * Time.deltaTime;
        /*if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
             }
        }*/

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3)
            {
                desiredLane = 2;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1)
            {
                desiredLane = 0;
            }
        }

        Vector3 targetPosition = transform.position.z * transform.forward; //+ transform.position.y * transform.up;

        if (desiredLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }
        else if (desiredLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = Vector3.Lerp(transform.position, targetPosition, 80 * Time.fixedDeltaTime);
        //controller.Move(direction * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        controller.Move(direction * Time.fixedDeltaTime);
        //Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        //rb.MovePosition(rb.position + forwardMove);
    }

    private void Jump()
    {
        direction.y = jumpForce;
        //float height = GetComponent<Collider>().bounds.size.y;
        //bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);
        
        //rb.MovePosition 
        
    }
}
