using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour { //Detta script ska visa hur mycket poäng Pac Man har.

	private int scoreText;
	
	void Update () {

		scoreText = GameObject.Find ("GameBrain").GetComponent<GameBrain>().WhatScore();

		gameObject.GetComponent<Text>().text = scoreText.ToString();
	
	}
}
