using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	public GameObject player;
	public Vector3 startPos;
	private int level = 1;
	private Rigidbody rb;
	private PlayerMovement pScript;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Capsule");
		//reference to the players rigidbody
		rb = player.GetComponent<Rigidbody> ();
		//player script
		pScript = GameObject.Find ("Capsule").GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeLevel(){
		//sets the velocity to 0
		rb.velocity = Vector3.zero;
		//teleports the player to its start position(set manually)
		player.transform.position = startPos;
		pScript.frozenTime = 1;
		level++;
	}
}
