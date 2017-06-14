using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	static public int score = 1000;
	public Text highScoreGT;

	void Update()
	{
		GameObject highScoreGO = GameObject.Find ("HighScore");
		highScoreGT = highScoreGO.GetComponent<Text> ();
		highScoreGT.text = "High Score: " + score;
	}
}
