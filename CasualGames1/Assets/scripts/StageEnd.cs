using UnityEngine;
using System.Collections;

public class StageEnd : MonoBehaviour {

	public GameObject player;
	public GameObject GM;

	private gameManager gmScript;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Capsule");
		//manager script reference
		gmScript = GameObject.Find ("GM").GetComponent<gameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		//collision between player and end object
		if (col.gameObject == player) {
			gmScript.changeLevel();
		}
	}
}
