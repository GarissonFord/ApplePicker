using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject apple;
	//Time in seconds until next apple
	public float appleRate;
	private float nextApple;
	// Use this for initialization

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () 
	{

		if (Time.time > nextApple)
		{
			nextApple = Time.time + appleRate;

			Vector3 position = transform.position;
			position.y -= 3.0f;
			Quaternion rotation = transform.rotation;
			Instantiate (apple, position, rotation);
		}
	}

	void FixedUpdate()
	{
		rb.velocity = new Vector3 (Random.Range(-10.0f, 10.0f), 0.0f, 0.0f);
	}
}
