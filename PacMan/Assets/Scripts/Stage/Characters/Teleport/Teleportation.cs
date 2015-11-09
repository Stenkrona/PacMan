using UnityEngine;
using System.Collections;

public class Teleportation : MonoBehaviour {

		public GameObject moveToZone; //flyttar GameObjectet, som krockar, till ett GameObject som man anger i inspector.
		

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.CompareTag("Character") || col.gameObject.CompareTag("Ghost"))
		   {
				
				Vector3 zonePos = moveToZone.transform.position;

				col.gameObject.GetComponent<Transform>().position = zonePos;



						
			}
	}
}
