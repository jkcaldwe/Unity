using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess -1;
			nextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess+1;
			nextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return))
		{
			print ("I won!");
			StartGame();
		}
	}
	
	void nextGuess()
	{
		guess = (min + max)/2;
		print (min + " " + max + " " + guess);
		print ("Is you number higher or lower " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal.");
	}
	
	void StartGame()
	{
		print ("=======================");
		print("Welcome to Number Wizard!");
		print("Pick a number in your head but don't tell me!");
		
		max = 1000;
		min = 1;
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		guess = max/2;
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up arrow for higher, down for lower, return for equal.");
	}
}
