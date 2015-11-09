using UnityEngine;
using System.Collections;

public class Result : MonoBehaviour { // Aktiverar antingen förlorar texten eller vinnar texten.

	public GameObject win;       //olika object som ska dyka upp när spelet är slut, olika saker kommer upp beroende på om man vann eller inte.
	public GameObject fail;
	public GameObject tryAgain;
	public GameObject playAgain;
	public GameObject mainMenu;

	private GameBrain winner; // en variabel som ska visa om metoden Win i GameBrain retunerar true eller false.
	private GameBrain loser; //en variabel som ska visa om metoden Fail i GameBrain retunerar true eller false.


	private bool i = true; // denna if-sats är till för att spelet inte ska kolla en gång till efter att det redan är gjort.

	void Start()
	{
		winner = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
		loser = GameObject.Find ("GameBrain").GetComponent<GameBrain>();
	}

	void Update () {
	
		if(i == true) // denna if-sats är till för att spelet inte ska kolla en gång till efter att det redan är gjort.
		{
		
						if(winner.DiDIWin() == true) //Kollar i GameBrain om spelaren vann.
						   {

								new EnableDis(win);
								new EnableDis(playAgain);
								new EnableDis(mainMenu);
									
									i = false;

							}
						if (loser.DidILose() == true) //Kollar i GameBrain om spelaren förlorade.
						{
						new EnableDis(fail);
						new EnableDis(tryAgain);
						new EnableDis(mainMenu);

				     				i = false;
						}
		}
	}

	public void AllTextFalse()
	{
		win.SetActive(false);
		fail.SetActive(false);
		playAgain.SetActive(false);
		tryAgain.SetActive(false);
		mainMenu.SetActive(false);
	}
	
}
