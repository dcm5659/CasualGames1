using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public float jumpForce;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space was pressed");
            Jump();
            
        }	
    }

    void Jump()
    {
        rb.AddForce(transform.up * jumpForce);
        Debug.Log("Jumping");
    }
}
