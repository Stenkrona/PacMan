using UnityEngine;
using System.Collections;

public class OnBonusItem : MonoBehaviour {

	private GameObject pacMan;
	private GameBrain gb;
	private BonusPoints bP;


	void Start () {

		pacMan = GameObject.Find ("PacMan");
		gb = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
		bP = GameObject.Find ("FruitPlaces").GetComponent<BonusPoints>();
	
		bP.IsBonusItem();
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
