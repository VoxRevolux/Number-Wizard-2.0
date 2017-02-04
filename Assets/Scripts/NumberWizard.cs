using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;
    public int MaxGuess = 10;

    Random rand = new Random();

    public Text text;

    // Use this for initialization
    void Start () {
        max = 1000;
        min = 1;
        NextGuess();
	}
	
    public void HigherThanGuess() {
        min = guess;
        NextGuess();
    }

    public void LowerThanGuess() {
        max = guess;
        NextGuess();
    }

    public void CorrectGuess() {
        Application.LoadLevel("Win");
    }

    public void NextGuess() {
        guess = Random.Range(min, max+1);
        MaxGuess--;

        text.text = "Is it " + guess.ToString() + "?";

        if(MaxGuess == 0 ) {
            Application.LoadLevel("Lose");
        }

        return;
    }
}
