using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour {

	public GameObject applePrefab;

	public float speed = 1f;

	//Reference to how far left and right tree can move 
	public float leftAndRightEdge = 10f;

	public float chanceToChangeDirections = 0.1f;

	public float secondsBetweenAppleDrops = 1f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Movement
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		//Change direction
		if (pos.x < -leftAndRightEdge) 
		{
			speed = Mathf.Abs (speed); //Moves right
		}
		else if(pos.x > leftAndRightEdge)
		{
			speed = -Mathf.Abs (speed); //Moves left
		}
	}
}
