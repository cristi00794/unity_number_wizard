using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	/// Use this for initialization
	int max;
	int min;
	int guess;

	public int maxGuessesAllowed = 10;

	public Text guessText;

	void Start () {
		StartGame();
	}
	void StartGame () {
		max = 1000 + 1;
		min = 1;
		NextGuess ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) { 
			GuessLower();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			GuessLower();
		}
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	void NextGuess () {
		guess =(int) Random.Range(min,max);
		maxGuessesAllowed --;
		guessText.text = guess.ToString();
		if (maxGuessesAllowed == 0) {
			Application.LoadLevel("Win");
		}
	}
}
