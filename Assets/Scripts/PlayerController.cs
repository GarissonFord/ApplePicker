using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

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
			(Input.mousePosition.x, 16.0f, 10.0f)
		);
	}
}
