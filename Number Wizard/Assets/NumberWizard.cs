using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	int Max;
	int Min;
	int Guess;

	public int MaxGuessAllow=10;
	public  Text text;

	// Use this for initialization
	void Start () {
		startgame ();
	}
	void startgame (){
		Max = 1000;
		Min = 1;
		NextGuess ();
	}
	public void GuessHigher(){
		Min = Guess;
		NextGuess ();

	}
	public void GuessLower(){
		Max = Guess;
		NextGuess ();
	}
	void NextGuess(){
		Guess = Random.Range (Min, Max + 1);
		text.text = Guess.ToString ();
		MaxGuessAllow = MaxGuessAllow - 1;
		if (MaxGuessAllow <= 0) {
			Application.LoadLevel ("win");
		}
	}


	
}
