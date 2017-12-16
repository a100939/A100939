using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {
    public static ScoreManager instance;

    public Text Player1ScoreText;
    public Text Player2ScoreText;

    public int Player1Score;
    public int Player2Score;
    // Use this for initialization
    void Start () {
        instance = this;
       // Player1Score = Player2Score = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Player1ScoreMain()
    {
        Player1Score +=1;
        Player1ScoreText.text = Player1Score.ToString();
    }


    public void Player2ScoreMain()
    {
       
        Player2ScoreText.text = Player2Score.ToString();
    }
    public void totalScore()
    {

    }
}
