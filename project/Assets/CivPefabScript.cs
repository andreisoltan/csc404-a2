using UnityEngine;
using System.Collections;

public class CivPefabScript : MonoBehaviour {
	
	GameObject heli;
	int speed = 5;
	Vector3 heli_pos, my_pos;
	
	// Use this for initialization
	void Start () {
		heli = GameObject.Find("Heli");
	}
	
	// Update is called once per frame
	void Update () {
	
		
		heli_pos = heli.transform.position;
		my_pos = transform.position;
		
		if((Mathf.Abs(my_pos.x-heli_pos.x) <= 1) &&
			(Mathf.Abs(my_pos.z-heli_pos.z) <= 1)) {
			print("Within range");
			Destroy(gameObject);
		}
		
		heli_pos.y = transform.position.y;
		
		transform.LookAt(heli_pos);
		rigidbody.AddRelativeForce(Vector3.forward*speed, ForceMode.Force);
	
	}
}
