using UnityEngine;
using System.Collections;

public class ScreenFade : MonoBehaviour {

	public float fadeSpeed = 1.5f;
	int cycle = 1;
	private bool sceneStarting = true;

	void Awake(){
		GetComponent<GUITexture>().pixelInset = new Rect (0f, 0f, Screen.width, Screen.height);
	}

	void Update(){
		if(cycle < 1){
			EndScene();
			StartScene();
		}
	}

	void FadeToClear(){
		// Lerp the colour of the texture between itself and transparent.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, fadeSpeed * Time.deltaTime);
	}

	void FadeToBlack(){
		// Lerp the colour of the texture between itself and transparent.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, fadeSpeed * Time.deltaTime);
	}

	void StartScene(){
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(GetComponent<GUITexture>().color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			GetComponent<GUITexture>().color = Color.clear;
			GetComponent<GUITexture>().enabled = false;
			
			// The scene is no longer starting.
			sceneStarting = false;
		}
	}

	public void EndScene ()
	{
		// Make sure the texture is enabled.
		GetComponent<GUITexture>().enabled = true;
		
		// Start fading towards black.
		FadeToBlack();
		
		// If the screen is almost black...
		//if(GetComponent<GUITexture>().color.a >= 0.95f)
			// ... reload the level.
			//Application.LoadLevel(0);
	}
}
