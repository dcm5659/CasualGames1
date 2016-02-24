using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    
    public Rigidbody rb;

    private bool jumping;
	private float jumpForce;
	private float moveForce;
    private float maxSpeed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        jumping = false;
        jumpForce = 400;
        moveForce = 10;
        maxSpeed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Jump();
        }
        Move();
        fallCheck();
    }

    void Jump()
    {
        if (!jumping)
        {
            rb.AddForce(transform.up * jumpForce);
            Debug.Log("Jumping");
            jumping = true;
        }
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * moveForce * -1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * moveForce);
        }
        if (rb.velocity.x > maxSpeed || rb.velocity.x < -1 * maxSpeed)
        {
            Vector3.ClampMagnitude(rb.velocity, maxSpeed);
            Debug.Log("CLAMPS!");
        }

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Platform")
        {
            jumping = false;
            Debug.Log("able to jump");
        }
    }

    void fallCheck()
    {
        if (rb.velocity.y < -1)
        {
            jumping = true;
            //Debug.Log("falling!");
        }
    }
}
