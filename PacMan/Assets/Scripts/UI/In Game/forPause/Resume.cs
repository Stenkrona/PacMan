using UnityEngine;
using System.Collections;

public class Resume : MonoBehaviour {

	public void Return()
	{
		GameObject.Find ("Main Camera").GetComponent<Pause>().Resume();
		Time.timeScale = 1f;
	}
}
