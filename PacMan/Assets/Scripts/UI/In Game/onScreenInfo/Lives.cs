using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour { //script som ska visa antal liv som Pac Man har.

	private int lives;
	
	// Update is called once per frame
	void Update () {
	
		lives = GameObject.Find("GameBrain").GetComponent<GameBrain>().WhatLives();

		GetComponent<Text>().text = lives.ToString();
	
	}
}

