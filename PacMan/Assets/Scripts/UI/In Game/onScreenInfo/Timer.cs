using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour { // hämtar tiden hos GameBrain och ger det till texten på GameObjectet.


	private float time;

	private GameBrain t; //Pekar på GameBrain Componenten på GameBrain objectet.

	void Start()
	{
		t = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	}

	void Update () 
	{

		time = t.WhatTime();

		int intTime = (int)time; //Vi vill tabort decimalerna. 

		GetComponent<Text>().text = intTime.ToString(); 
	
	}
}
