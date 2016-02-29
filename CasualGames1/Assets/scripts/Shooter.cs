using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject prefab;
	public int ammo = 5;

    Light mainLight;
    // Use this for initialization
    void Start () {
        mainLight = GameObject.Find("Directional Light").GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("f"))
        {
            spawnFlare();
        }

        if (Input.GetKeyDown("l"))
        {
            mainLight.enabled = !mainLight.enabled;
        }
    }

    void spawnFlare() {
		if(ammo > 0){
			Vector3 pos = GameObject.Find("Capsule").transform.position;
			Instantiate(prefab, new Vector3(pos.x + 0.5f, pos.y + 4, pos.z), Quaternion.identity);
			ammo--;
		}
    }
}
