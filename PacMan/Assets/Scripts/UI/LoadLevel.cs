using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public int level;

	public void LoadL()  //hämtar den level med det nr.
	{ 

		Application.LoadLevel(level);

		DontDestroyOnLoad(GameObject.Find("GameBrain"));

	}

	public void ReloadLevel() //Laddar om banan som man är på.
	{
		int loadedLevel = Application.loadedLevel;

		Application.LoadLevel(loadedLevel);
	}
}
