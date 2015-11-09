using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	GameBrain i; //pekar på componenten GameBrain på objectet GameBrain.
	Result r; //pekar på componenten Result som finns på Objectet Main Camera.

	void Start()
	{
		i = GameObject.Find("GameBrain").GetComponent<GameBrain>();

	}
	
	
	public void Restart() { // en funktion som sätter alla stats på GameBrain till sitt ursprungliga värde.
		
			i.Reset();

	}
	
}

