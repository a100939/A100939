using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDeScript : MonoBehaviour {
    int num1 = 50;

    // Use this for initialization
    void Start () {
        StartGame();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            num1++;
            print(num1);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            num1--;
            print(num1);
        }


        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("The game has stopped!!");
            print(num1);
            UnityEditor.EditorApplication.isPlaying = false; // to stop the game
        }

    }
    void StartGame()
    {
        print("Hello Welcome to Increment/Decrement Game");
        print("UP ARROW will INCREMENT, DOWN ARROW will DECREMENT & ENTER will STOP");
    }
}



 
   

    


    
    
  


