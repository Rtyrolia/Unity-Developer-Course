using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;

	// Use this for initialization
	void Start () {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is : " + max);
        Debug.Log("The lowest number is : " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Press Up = Higher , Press Down = Lower , Press Enter = Correct");
        max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your guess higher or lower than ..." + guess);
        }
        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is your guess higher or lower than ..." + guess);
        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("That's correct, smashed it!");
        }

	}
}
