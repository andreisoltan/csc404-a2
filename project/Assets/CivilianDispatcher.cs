using UnityEngine;
using System.Collections;

public class CivilianDispatcher : MonoBehaviour {
	
	public GameObject civ;
	public GameObject heli;
	int t;
	float timer;
	
	// Use this for initialization
	void Start () {
		heli = GameObject.Find("Heli");
		timer = 2.0f;		
	}
	
	// Update is called once per frame
	void Update () {
		
		timer -= Time.deltaTime;
		
		if(timer <= 0) {
			generateCivilian();
			timer = 2.0f;
		}
		
	}
	
	GameObject generateCivilian() {
		
		GameObject c;
			
		int x, y, z;
		int speed = 5;
		y = 1;
		Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
		
		c = (GameObject) Instantiate(civ, pos, Quaternion.identity);
		
		pos = heli.transform.position;
		pos.y = y;
			
		c.transform.LookAt(pos);
		c.rigidbody.AddRelativeForce(Vector3.forward*speed, ForceMode.Force);
		
		return c;
	}
	
}
