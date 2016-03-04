using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class title : MonoBehaviour {
	public Color a;
	public Color b;
	public int lerpTime=1;
	public Text flashy;

	void Start()
	{
		flashy.GetComponent<Text> ();
	}
	void Update() 
	{
		flashy.color = Color.Lerp (a,b,Mathf.PingPong(Time.time,lerpTime));
	}
}