using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {
	public GameObject goal;
	public GameObject player;
	public Text distToEnd;
	public Text controlText;

	private float dist;
	private int round;
	// Use this for initialization
	void Start () {
		goalDistance ();
	}
	
	// Update is called once per frame
	void Update () {
		goalDistance ();
	}

	void goalDistance()
	{
		dist = Vector3.Distance (goal.transform.position,player.transform.position);
		round = Mathf.RoundToInt (dist);
		distToEnd.text = "Distance to End: " + round.ToString();
	}
}
