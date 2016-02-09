using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public int speed = 20;
	// Use this for initialization
	void Start () {
        Rigidbody rb = this.GetComponent<Rigidbody>();
        rb.velocity = Camera.main.transform.up * speed;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
