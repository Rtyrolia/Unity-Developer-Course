using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number");
        Debug.Log("The highest number is : " + max);
        Debug.Log("The lowest number is : " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Press Up = Higher , Press Down = Lower , Press Enter = Correct");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

