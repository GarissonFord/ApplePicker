using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Basket : MonoBehaviour {

	public Text scoreGT;

	void Start()
	{
		GameObject scoreGO = GameObject.Find ("ScoreCounter");
		scoreGT = scoreGO.GetComponent<Text> ();
		scoreGT.text = "0";
	}

	// Update is called once per frame
	void Update () 
	{
		//Current screen position of mouse
		Vector3 mousePos2D = Input.mousePosition;
		//Because camera's Z position is -10, we need the reverse to push the mouse
		mousePos2D.z = -Camera.main.transform.position.z;
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint (mousePos2D);
		//Move x position of basket to mouse x position
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}

	void OnCollisionEnter(Collision coll)
	{
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.CompareTag ("Apple"))
			Destroy (collidedWith);

		int score = int.Parse (scoreGT.text);
		score += 100;
		scoreGT.text = score.ToString ();
	}
}
