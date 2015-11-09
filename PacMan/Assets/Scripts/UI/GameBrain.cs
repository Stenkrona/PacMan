using UnityEngine;
using System.Collections;

public class GameBrain : MonoBehaviour { //Spelets hjärna som kommer ihåg allt.

	public float time;

	public int score;
	public int lives;

	public int dots;

	public bool gameStarted;
	public bool win = false;
	public bool failure = false;
	public bool gameover = false;
	public bool startTime;
	
	void Start()
	{
		dots = 266;
		time = 5f;
		startTime = false;
		lives = 3;
		gameStarted = false;
	}

	void Update()
	{
		if(gameStarted == true)
		{
				if(gameover == false)
				{
					if( dots == 0) // När det inte finns några Dots kvar vinner pac man.
							{
								Win();
								new ToggleTheTime();
					Time.timeScale = 0f;
							}

							if(lives == 0) //Pac Man dör om han förlorar alla sina liv.
							{
								Fail ();
								new ToggleTheTime();
					Time.timeScale = 0f;
							}

							if(time >= 180f) //om tiden blir noll förlorar spelaren.
							{
								Fail ();
								new ToggleTheTime();
					Time.timeScale = 0f;
							}

							if(startTime == true) //när startTime är på börjar timern.
							{
								Timer();
							}
		}
		}
	}

	public void Timer() //Räknar upp time variabeln.
	{

		time += Time.deltaTime;

	}
	public void ScoreBonus()
	{
		score = score + 200;
	}

	public void ScoreDots() //Denna metod ska anropas när pac man äter upp en dot.
	{
		dots--;
		score = score + 10;
	}
	public void Die() //Pac Man ska kalla på den här metoden när han dör.
	{
		lives--;
	}

	public void Reset() // Detta är default värdena.
	{

		score = 0;
		lives = 3;
		time = 0;
		dots = 266;
		win = false;
		
		failure = false;
		
		gameover = false;

		GameObject.Find ("Main Camera").GetComponent<Result>().AllTextFalse();
	}

	public void Win() //Anropas i Update när en spelare vinner.
	{
		win = true;
		gameover = !gameover;
	}

	public void Fail() //Anropas i Update när en spelare förorar.
	{
		failure = true;
		gameover = !gameover;
	}
	public void ToggleTime()  
	{
		startTime = !startTime;
	}
	public void ToggleGameStarted()
	{
		gameStarted = !gameStarted;
	}

	public int WhatScore() //Dessa metoder är till för att ge information.
	{
		return(score);
	}
	public int WhatLives()
	{
		return(lives);
	}
	public float WhatTime()
	{
		return(time);
	}
	public bool DiDIWin()
	{
		return(win);
	}
	public bool DidILose()
	{
		return(failure);
	}
	public bool IsGameOver()
	{
		return(gameover);
	}
	public bool IsGameRunning()
	{
		return(gameStarted);
	}
	public int HowManyDots()
	{
		return(dots);
	}
	
}
