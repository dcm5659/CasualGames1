using UnityEngine;
using System.Collections;

public class tip : MonoBehaviour {
	public float duration = 1.0F;
	public Renderer rend;
	private GameObject block;

	void Start() {
		rend = GetComponent<Renderer>();
		block = GameObject.Find ("bouncy");
	}
	void Update() {
		if (block.activeInHierarchy) 
		{
			Color col = rend.material.color;
			col.a = Mathf.Lerp (col.a, 0f, 0.01f);
			rend.material.color = col;
		}
	}
}