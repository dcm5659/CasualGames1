using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public Button start;
	public Button quit;

	void Start ()
	{
		start = start.GetComponent<Button> ();
		quit = quit.GetComponent<Button> ();
	}

	public void StartGame()
	{
		Application.LoadLevel (1); 

	}

	public void Quit()
	{
		Application.Quit();

	}

}