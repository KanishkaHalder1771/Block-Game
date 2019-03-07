using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameButton : MonoBehaviour {

    [SerializeField] Text text;

    int max = 1000, min = 0, guess, undo_min, undo_max;
    private void Start()
    {
        NewGuess();
    }

    void NewGuess()
    {
        guess = (min + max) / 2;
        text.text = guess.ToString();
    }

    public void Higher()
    {
        min = guess;
        NewGuess();
    }
    public void Lower()
    {
        max = guess;
        NewGuess();
    }

}
