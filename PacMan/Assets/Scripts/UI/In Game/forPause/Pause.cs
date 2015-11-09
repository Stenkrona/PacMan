using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	public GameObject resumeButton; //knappen för Resume.
	public GameObject mainMenuButton; // Knapp för Main Menu.

	public GameObject text; // Text som består av " Pause".

	public GameBrain gameover; //ska peka på GameBrain Componenten i GameBrain Objectet.
	public bool state; //en variabel som är till för att toggla ett GameObject av eller på i Metoden EnableDis.

	void Start()
	{
		state = true;
		gameover = GameObject.Find("GameBrain").GetComponent<GameBrain>();
	}


	void Update () {

		if(gameover.IsGameOver() == false) // Kollar om spelet är över eller inte, är det inte det kan man pausa spelet.
		{
				if(Input.GetKeyDown(KeyCode.Escape)|| Input.GetKeyDown(KeyCode.P)) // Pausa spelet med esc eller P.
				{
					Time.timeScale = 0; // Gör så att unity tiden stannar så det händer inget.

					new EnableDis(resumeButton); // Sätter på några knappar och text som ska synas under pausen.
					new EnableDis(text);
					new EnableDis(mainMenuButton);
				    

				}
		}
	
	}
		
	public void Resume() //Tar bort alla pause relaterade object och sätter igång spelet.
	{
		Time.timeScale = 1;

		new EnableDis(resumeButton);
		new EnableDis(text);
		new EnableDis(mainMenuButton);
		
	}
	
}
