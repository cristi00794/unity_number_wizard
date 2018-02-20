using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string level){
		Debug.Log ("Level load requested");
		Application.LoadLevel (level);
	}

	public void QuitRequest(){
		Debug.Log ("Quit request");
		Application.Quit ();
	}
}
