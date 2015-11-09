using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	private float x;
	private float v;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Movement();
				}
	public void Movement()
	{
		v = Input.GetAxis("Vertical");
		GetComponent<Rigidbody>().AddForce(new Vector3 (v,0f,0f) * speed);

		x = Input.GetAxis("Horizontal");
		GetComponent<Rigidbody>().AddForce(new Vector3 (0f,0f,x) * speed);

	}
}

