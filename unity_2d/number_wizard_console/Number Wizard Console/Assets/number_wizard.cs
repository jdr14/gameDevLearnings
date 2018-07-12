using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class number_wizard : MonoBehaviour {

    // Define the global (with respect to the containing class) variables here
    int currentGuess = 500;
    int maxGuess = 1000;
    int minGuess = 1;
    string userName = "Joey";

    /* 
     * When the game first runs, the start method is called once
     * this is good for running methods that deal with setup because it
     * is only run once.  Use this for initialization
     */
	void Start () 
    {
        // Opening message of the guessing game
        startGame();
	}

    void startGame()
    {
        // Maintain original values if/when the game is restarted
        currentGuess = 500;
        maxGuess = 1000;
        minGuess = 1;

        Debug.Log("Moin!  Welcome to the number wizard " + userName + " !");
        Debug.Log("To start the game, pick a number...");
        Debug.Log("Highest number you can pick is: " + maxGuess);
        Debug.Log("Lowest number you can pick is: " + minGuess);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxGuess = maxGuess + 1;
    }
	
	/*
	 * Update deals with anything that deals with live update (i.e. this
	 * is called every frame per second.  The frames/second rate depends
	 * on type of computer this is executed on.
	 */
	void Update () 
    {
        // Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");

            // Update the value for the minimum guess
            minGuess = currentGuess;

            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
        {
            Debug.Log("Down Arrow key was pressed.");

            // Update the value for the maximum guess
            maxGuess = currentGuess;

            nextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed it correctly!!!");
            startGame();  // Start the game again
        }
        // Else is not needed to end an if/else if code block     
	}

    void nextGuess()
    {
        // Update the value for the current guess
        currentGuess = (maxGuess + minGuess) / 2;

        Debug.Log("Is it higher or lower than " + currentGuess);
    }
}
