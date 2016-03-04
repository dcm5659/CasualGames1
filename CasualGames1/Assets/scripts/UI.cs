using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI : MonoBehaviour {
	public GameObject goal;
	public GameObject player;

	public Text distToEnd;
	public Text controlText;
	public Text frozenTimer;

	private float dist;
	private float freeze;

	private int round;

	private PlayerMovement still;
	// Use this for initialization
	void Start () {
		still=GameObject.Find("Capsule").GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		goalDistance ();
		showFreeze();
	}

	void goalDistance()
	{
		dist = Vector3.Distance (goal.transform.position,player.transform.position);
		round = Mathf.RoundToInt (dist);
		distToEnd.text = "Distance to End: " + round.ToString();
	}

	void showFreeze()
	{
		freeze=Mathf.Round(still.frozenTime*10);
		freeze=freeze/10;
		if(freeze>0)
		{
			frozenTimer.text="Frozen for: " + freeze.ToString() + " seconds";
		}
		else
		{
			frozenTimer.text="";
		}
	}
}
