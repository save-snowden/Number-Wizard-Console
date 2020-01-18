using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome To Number Wizard..\n");
        Debug.Log("Pick a Number.. Do not tell me what it is..");
        Debug.Log("The Highest Number you can pick is : " + max);
        Debug.Log("The Lowest Number you can pick is  : " + min);
        Debug.Log("Tell me if your Number is Higher or Lower than : " + guess);
        Debug.Log("Push Up == Higher ||| Push Down = Lower ||| Push Enter = Correct !");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        { 
            min = guess;
            NextGuess();
        }

        //Detect when the down arrow key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {            
            max = guess;
            NextGuess();
        }

        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("\nYou Know who I am.. My Man..\n");
            Debug.Log("Lets Play Again??\n\n");
            StartGame();
            
            
        }


    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Ahh. your guess is Higher or Lower Than :  " + guess);
    }

}
