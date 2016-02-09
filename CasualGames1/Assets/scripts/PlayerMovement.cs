using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    private float jumpForce;
    private float moveForce;
    public Rigidbody rb;
    private bool jumping;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        jumping = false;
        jumpForce = 400;
        moveForce = 10;
	
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
            Debug.Log("falling!");
        }
    }
}
