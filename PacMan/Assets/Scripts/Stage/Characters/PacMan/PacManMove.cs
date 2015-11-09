using UnityEngine;
using System.Collections;

public class PacManMove : MonoBehaviour 
{
	public float speed = 5.0f;
	public Transform spawnPoint;
	private AudioSource source;
	public AudioClip death;
	
	
	// Use this for initialization
	void Start () 
	{
		source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement();
	}
	
	void Movement ()
	{
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		
		if (Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.A))
			transform.rotation *= Quaternion.Euler(0, -90, 0);
		
		if (Input.GetKeyDown(KeyCode.RightArrow)|| Input.GetKeyDown(KeyCode.D))
			transform.rotation *= Quaternion.Euler(0, 90, 0);
		
		if (Input.GetKeyDown(KeyCode.DownArrow)|| Input.GetKeyDown(KeyCode.S))
			transform.rotation *= Quaternion.Euler(0, 180, 0);
	}
	
	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Enemy")
			gameObject.transform.position = spawnPoint.transform.position;
		source.PlayOneShot (death,1f);
	}
}