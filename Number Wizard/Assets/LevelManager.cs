using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLeve(string LevelNames){
		Debug.Log ("Requested level" + LevelNames);
		Application.LoadLevel (LevelNames);
	}
	public void QuitLevel(){
		Debug.Log ("i want to Quit");	
		Application.Quit ();
	}
}
