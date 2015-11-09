using UnityEngine;
using System.Collections;

public class ToggleTheTime {

	public ToggleTheTime()
	{
		GameObject.Find ("GameBrain").GetComponent<GameBrain>().ToggleTime();
	}


}
