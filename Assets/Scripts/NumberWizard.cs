using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min, max;
    int guess;
    [SerializeField] Text guessDisplay;

    // Use this for initialization
    void Start () {
        StartGame();
	}

    void StartGame()
    {
        UpdateGuess();
        max += 1;
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        UpdateGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = Random.Range(min, max);
        guessDisplay.text = (guess.ToString());
    }
}
