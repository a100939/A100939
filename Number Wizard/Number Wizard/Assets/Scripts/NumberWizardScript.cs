using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizardScript : MonoBehaviour {
    public Text guessText;
    int min = 0;
    int max = 0;
    int guess = 0;


    // Use this for initialization
    private void Start()
    {
        StartGame();
       
    }


    // Update is called once per frame
    void Update()
    {
    }
      
    
 
   void NextGuest()
    {
        guess = (min + max) / 2;
        guessText.text = guess + "?";
     
    }
    public void GuessHigher()
    {
        min = guess + 1;
        NextGuest();
    }
    public void LowerHigher()
    {
        max = guess + 1;
        NextGuest();
    }
}
