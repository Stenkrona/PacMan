using UnityEngine;
using System.Collections;

public class EnableDis { //togglar av och på ett GameObject i hieraarchy.

	private bool state;

	public EnableDis(GameObject o) 
	{
		bool state;
		
		GameObject item = o;
		
		state = item.activeInHierarchy;
		
		item.SetActive(!state); 
	}

}
