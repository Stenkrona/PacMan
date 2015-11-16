using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AI : MonoBehaviour {

	public List<GameObject> ghosts; // lista på hur många spöken man vill använda.
	public List<Transform> spawns; // lista på spawn platser. 

	public Vector3[] corners; // en array med vector3 kordinater som ska sättas i varje hörn. 
	private Vector3 pacman;

	public float speed; //hastigheten på spöken. 

	public int g; //med denna variabel sätter man antalet spöken som ska vara med. 
	private int d;

	public Vector3[][] destinations; //en array med destinationer som spökena ska gå till, menat att vara mot Pacman eller hörnen. 

	
	void Start () {

		pacman = GameObject.Find("PacMan").GetComponent<Transform>().position;

		destinations = new Vector3[ghosts.Count][];

		for(int i = 0; i <= ghosts.Count; i++)
		{
			destinations[i] = new Vector3[]{corners[Random.Range(0,ghosts.Count)], pacman, corners[Random.Range (0,ghosts.Count)]};
		}

		g = ghosts.Count;

		for(int i = 0; i <= g; i++)
		{
			Instantiate(ghosts[i], spawns[i].position , Quaternion.identity); // Spawnar alla spöken som finns i ghosts listan.
		}

		corners[4] = new Vector3 []{GameObject.Find("TopRight").GetComponent<Transform>().position ,GameObject.Find("TopLeft").GetComponent<Transform>().position,
			GameObject.Find("BottomLeft").GetComponent<Transform>().position, GameObject.Find("BottomRight").GetComponent<Transform>().position}; //En Array mennat för att hålla kordinaterna 
																																	//för hörnen.

		DontDestroyOnLoad(gameObject);




	}
	

	void Update () {
	
	}
	public void GhostBehaviour(int o)
	{
		int ghostMove = o;

		for(int i = 0; i <= ghosts.Count; i++);
		{

		}
	}
}
