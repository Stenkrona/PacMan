using UnityEngine;
using System.Collections;

public class DotSpin : MonoBehaviour {

	public float spinSpeed;


	void Update () {
	
		Spin ();

	}

	void Spin()
	{
		transform.RotateAround(transform.position, new Vector3(0f,1f,0f), spinSpeed);

	}
}
