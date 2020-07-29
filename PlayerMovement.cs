using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float turnSpeed = 4f;
    public float jumpPower = 3f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Turn();
        Move();

       if (Input.GetKeyDown("space"))
       {
           Jump();
       
       }
}

    public void Turn()
    {
        float yRotation = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        gameObject.transform.Rotate(0f, yRotation, 0f);
    }

    public void Move()
    {
        Vector3 forwardMovement = transform.forward * Input.GetAxis("Vertical") * moveSpeed;

        rb.velocity = new Vector3(0, rb.velocity.y, 0) + forwardMovement;
    }

    public void Jump()
    {
        rb.AddForce(0, jumpPower, 0, ForceMode.Impulse);
    }
}

