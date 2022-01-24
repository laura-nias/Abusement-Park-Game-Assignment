using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipulTargetCamera : MonoBehaviour {

	public List<Transform> targets;

	public Vector3 offset;
	public float smoothTime = .5f;

	public float minZoom = 40f;
	public float maxZoom = 10f;

	Vector3 velocity;

	void Start()
	{

	}
	void Update()
	{
		//Debug.Log (FindObjectOfType ("Player"));
	}
	void LateUpdate()
	{
		if (targets.Count == 0)
			return;
		Move ();
		Zoom();
	}
	void Zoom()
	{
		//Debug.Log (GetGreatestDistance ());
	}
	float GetGreatestDistance ()
	{
		var bounds = new Bounds (targets [0].position, Vector3.zero);
		for (int i = 0; i < targets.Count; i++) {
			bounds.Encapsulate (targets [i].position);
		}
		return bounds.size.x;
	}

	void Move()
	{
		Vector3 centrePoint = GetCentrePoint ();
		Vector3 newPosition = centrePoint + offset;

		transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
	}
	Vector3 GetCentrePoint()
	{
		if (targets.Count == 1) {
			return targets [0].position;
		}
		var bounds = new Bounds (targets [0].position, Vector3.zero);
		for (int i = 0; i < targets.Count; i++) 
		{
			bounds.Encapsulate (targets [i].position);
		}
		return bounds.center;
	}
}
