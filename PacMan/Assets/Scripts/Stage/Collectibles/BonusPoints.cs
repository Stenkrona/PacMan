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

	private float min;
	private float max;
	


	void Start () {

		min = 25;
		max = 35;
		d = 220;

		isBonus = false;

		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	
	}
	

	void Update () {

		randomTime = Random.Range(min,max);

		time = gb.WhatTime();

		if(time >= randomTime && gb.HowManyDots() <= d && isBonus == false)
		{
			Debug.Log ("hej");
			SpawnBonusPoints();
			ChangeTerms();
		}

	
	}
	public void SpawnBonusPoints()
	{
		r = Random.Range(0,9);
		i = Random.Range(0, bonusItems.Count);


		Instantiate(bonusItems[i], locations[r].position, Quaternion.identity);
	}
	void ChangeTerms()
	{
		d = d - 50;

		min = min + 20f;
		max = max + 20f;
	}
	public void IsBonusItem()
	{
		isBonus = !isBonus;
	}
}
