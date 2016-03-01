using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class gameManager : MonoBehaviour {

	public GameObject player;
	public SmoothFollow cam;
	public int levelCount = 2;
	public Vector3 startPos;

	private int level = 1;
	private Rigidbody rb;
	private PlayerMovement pScript;
	private Shooter shootScript;
	private List<Vector3> levelStarts;

	// Use this for initialization
	void Start () {
		//camera reference
		cam = GameObject.Find ("Main Camera").GetComponent<SmoothFollow>();
		//player reference
		player = GameObject.Find ("Capsule");
		//reference to the players rigidbody
		rb = player.GetComponent<Rigidbody> ();
		//player script
		pScript = GameObject.Find ("Capsule").GetComponent<PlayerMovement>();
		//player script
		shootScript = GameObject.Find ("Capsule").GetComponent<Shooter>();

		levelStarts = new List<Vector3> ();
		for(int i = 1; i < levelCount + 1; i++) {
			GameObject l = GameObject.Find("spawn" + i);
			Debug.Log (i + " is " + l.transform.position);
			levelStarts.Add(l.transform.position);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void changeLevel(){
		//sets the velocity to 0
		rb.velocity = Vector3.zero;
		//teleports the player to its start position(set manually)
		player.transform.position = levelStarts[level];
		//tranports the camera to the player after level transition
		cam.CorrectX (player.transform.position);
		//resets frozen timer
		pScript.frozenTime = 1;
		//resets ammo
		shootScript.Reload ();
		level++;
	}
}
