using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000, min = 0, guess, undo_min, undo_max;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame()
    {
        Debug.Log("Number Wizard");
        Debug.Log("Guess a number");
        Debug.Log("Highest Number:" + max);
        Debug.Log("Lowest Number:" + min);
        guess = (min + max) / 2;
        Debug.Log(guess);

    }

    void NewGuess() {
        guess = (min + max) / 2;
        Debug.Log("New guess:" + guess);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            undo_min = min;
            min = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NewGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("The number is " + guess);
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("Going back to last case.");
        }
    }
}
