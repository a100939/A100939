using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour {

    int min = 0;
    int max = 0;
    int guess = 0;
    int count = 0;
    public Text guessText;


    // Use this for initialization
    private void Start()
    {
        StartGame();
       
    }
	
	// Update is called once per frame
	void Update () {
     
   
    }
    void StartGame()
    {
        min = 1;
        max = 1000;

        NextGuest();
    }
    void NextGuest()
    {

        System.Random random = new System.Random();
        guess = random.Next(min, (max+1));
        guessText.text = guess + "?";
      
    }
    public void GuessHigher()
    {
        min = guess;
        count++;
        NextGuest();
        UserWins();


    }
    public void GuessLower()
    {
        max = guess;
        count ++;
        NextGuest();
        UserWins();
    }
    public void UserWins()
    {
        if (count == 8)
        {
            SceneManager.LoadScene("Win");
        }
        else NextGuest();
    }
    

}
