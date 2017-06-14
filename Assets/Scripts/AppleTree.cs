using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject apple;
	//Time in seconds until next apple
	public float nextAppleTime;
	// Use this for initialization

	// Update is called once per frame
	void Update () 
	{
		Vector3 position = transform.position;
		Quaternion rotation = transform.rotation;
		Instantiate (apple, position, rotation);
	}
}
