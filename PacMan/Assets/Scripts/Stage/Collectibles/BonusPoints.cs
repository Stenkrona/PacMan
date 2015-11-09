using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BonusPoints : MonoBehaviour {

	public List<Transform> locations;
	public List<GameObject> bonusItems;
	
	private int r;
	private int i;
	public int d;

	private GameBrain gb;

	public float time;
	public float randomTime;

	public bool isBonus;
	


	void Start () {


		d = 220;

		isBonus = false;

		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
		randomTime = Random.Range(25f,30f);
	
	}
	

	void Update () {

		time = gb.WhatTime();

		if(time >= randomTime && gb.HowManyDots() <= d && isBonus == false)
		{
			Debug.Log ("hej");
			SpawnBonusPoints();
			ChangeDotTerms();
		}

	
	}
	public void SpawnBonusPoints()
	{
		r = Random.Range(0,9);
		i = Random.Range(0, bonusItems.Count);


		Instantiate(bonusItems[i], locations[r].position, Quaternion.identity);
	}
	void ChangeDotTerms()
	{
		d = d - 50;
	}
	public void IsBonusItem()
	{
		isBonus = !isBonus;
	}
}
