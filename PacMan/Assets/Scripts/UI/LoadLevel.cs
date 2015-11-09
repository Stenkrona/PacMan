using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour { 

	public int level; 

	public void LoadL()  //hämtar den level med det nr.
	{ 

		Application.LoadLevel(level);

		DontDestroyOnLoad(GameObject.Find("GameBrain"));

		Time.timeScale = 1f; //Så att tiden inte är pausad när man kommer till scenen.

	}

	public void ReloadLevel() //Laddar om banan som man är på.
	{
		int loadedLevel = Application.loadedLevel;

		Time.timeScale = 1f;

		Application.LoadLevel(loadedLevel);
	}
}
