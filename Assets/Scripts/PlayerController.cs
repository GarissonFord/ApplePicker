using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float xMin, xMax;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate () 
	{	
		//The 10 in the Z axis is the distance from the camera, otherwise the player has the same z-coordinate as the camera
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3
			//This is actually making no sense
			(
				Mathf.Clamp(Input.mousePosition.x, xMin, xMax),
				66.0f, 
				10.0f
			)
		);
	}
}
