using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
	public int fadeTime;
	// Use this for initialization
	void Start () {
		fade();
	}

	void fade()
	{
		StartCoroutine(doFade());
	}
	
	IEnumerator doFade()
	{
		CanvasGroup canvasGroup=GetComponent<CanvasGroup>();
		while(canvasGroup.alpha>0)
		{
			canvasGroup.alpha-=Time.deltaTime/fadeTime;
			yield return null;
		}
		canvasGroup.interactable=false;
		yield return null;
	}
}
