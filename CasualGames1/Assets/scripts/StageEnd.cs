using UnityEngine;
using System.Collections;

public class StageEnd : MonoBehaviour {

	public GameObject player;
	public Vector3 startPos;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Capsule");
		//reference to the players rigidbody
		rb = player.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		//collision between player and end object
		if (col.gameObject == player) {
			//sets the velocity to 0
			rb.velocity = Vector3.zero;
			//teleports the player to its start position(set manually)
			player.transform.position = startPos;
		}
	}
}
