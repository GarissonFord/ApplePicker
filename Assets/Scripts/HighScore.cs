using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

	static public int score = 1000;
	public Text highScoreGT;

	void Awake()
	{
		//Reads score if it already exists
		if (PlayerPrefs.HasKey ("ApplePickerHighScore"))
			score = PlayerPrefs.GetInt ("ApplePickerHighScore");

		//Assigns high score to ApplePickerHighScore
		PlayerPrefs.SetInt("ApplePickerHighScore", score);
	}

	void Update()
	{
		GameObject highScoreGO = GameObject.Find ("HighScore");
		highScoreGT = highScoreGO.GetComponent<Text> ();
		highScoreGT.text = "High Score: " + score;

		//Can update ApplePickerHighScore in PlayerPrefs
		if (score > PlayerPrefs.GetInt ("ApplePickerHighScore"))
			PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}
}
