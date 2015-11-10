using UnityEngine;
using System.Collections;

public class OnBonusItem : MonoBehaviour {

	private GameObject pacMan;
	private GameBrain gb;
	private BonusPoints bP;

	private float time;
	private float min;
	private float max;


	void Start () {

		time = 0f;

		pacMan = GameObject.Find ("PacMan");
		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
		bP = GameObject.Find ("FruitPlaces").GetComponent<BonusPoints>();
	
		bP.IsBonusItem();
	}
	void Update()
	{
		time = Time.deltaTime;
		min = 10f;
		max = 15f;

		if(time >= Random.Range(min, max))
		{
			Destroy(gameObject);
		}



	}
	
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.name == pacMan.name)
		{
		bP.IsBonusItem();
		gb.ScoreBonus();
		Destroy(gameObject);
		}
	}
}
