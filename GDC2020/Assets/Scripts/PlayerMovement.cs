using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float turnSpeed = 4f;
    public float jumpPower = 3f;

    public Rigidbody rb;

    public int GroundTouched = 0;
    public Transform paw;
    public bool attack = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Turn();
        Move();


        if (Input.GetKeyDown("e"))
        {
            attack = true;
            Attack();
            
        }
        else if (Input.GetKeyUp("e"))
        {
            Recharge();
        }

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
        if(GroundTouched > 0)
        {
            rb.AddForce(0, jumpPower, 0, ForceMode.Impulse);
            GroundTouched = 0;
        }
        
    }

    public void Attack()
    {
        paw.Rotate(0, 50, 0);
        

    }


    public void Recharge()
    {
        paw.transform.localEulerAngles = new Vector3 (3.813f, 100f, 178.915f);

    }

    /*void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            GroundTouched ++;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            GroundTouched --;
        }


        

    }*/

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.gameObject.name == "Ground")
        {
            GroundTouched = 1;
        }
        
    }
}

