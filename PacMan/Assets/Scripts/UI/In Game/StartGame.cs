using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	private GameBrain s;

	void Start () {
	
		s = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	}
	
	public void StartG()
	{
		s.ToggleGameStarted();
	}
}
