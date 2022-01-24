using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	public float threshold;
	Rigidbody rigidBody;
	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < threshold) {
			transform.position = new Vector3 (0, 0, 0);
			rigidBody.velocity = new Vector3 (0, 0, 0);
			GetComponent<PlayerHealth> ().loseLife ();
		}
	}
}
