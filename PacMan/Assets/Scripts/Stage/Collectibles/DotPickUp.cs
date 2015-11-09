using UnityEngine;
using System.Collections;

public class DotPickUp : MonoBehaviour {

	GameBrain c;

	void Start()
	{
		c = GameObject.Find ("GameBrain").GetComponent<GameBrain>(); //pekar på Klassen GameBrain hos GameObjectet GameBrain
	}

void OnCollisionEnter(Collision col) //När detta GameObject krockar med ett Object som heter PacMan så får spelaren poäng och detta GameObject försvinner.
	{
		if(col.gameObject.name == ("PacMan")) 
		{
			c.ScoreDots();
			Destroy(gameObject);
		}
	}


}
