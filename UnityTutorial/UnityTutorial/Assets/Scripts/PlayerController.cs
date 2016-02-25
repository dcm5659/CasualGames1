﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;
	private GameObject[] pickUpArr;
	private int pickUpCount;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		pickUpArr = GameObject.FindGameObjectsWithTag ("Pick Up");
		pickUpCount = pickUpArr.Length;
		SetCounterText ();
		winText.text = "";
	}
	void FixedUpdate()
    {
		float moveHorizontal=Input.GetAxis("Horizontal");
		float moveVertical=Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
    }

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count=count+1;
			SetCounterText ();		
		}
	}

	void SetCounterText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >=pickUpCount) 
		{
			winText.text = "You Win!";
		}
	}
}