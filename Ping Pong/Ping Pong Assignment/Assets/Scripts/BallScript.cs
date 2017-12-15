using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//used this for text
using UnityEngine.UI;


public class BallScript : MonoBehaviour {
    //set name of varibale to change it to ball
    private Rigidbody2D ball;
    //set boolen to use later for game to start
    bool gameStarted = false;
    //set score text for player 1 & 2 will be displayed on the screen
    public Text Player1ScoreText;
    public Text Player2ScoreText;
    //set score per goal 
    public int ScorePerGoal;
    int[] totoalScore;
    public int score;



    // Use this for initialization
    void Start ()
    {
        //set varible to ball in game
        ball = GetComponent<Rigidbody2D>();
      
        //set postion of ball in center when starting the game
        ball.transform.position = new Vector3(0f, 0f,-5f);
    }

    // Update is called once per frame
    void Update()
    {
        //if game is false
        if (!gameStarted)
            //ball stays in center
            ball.transform.position = new Vector3(0f, 0f,-5f);
        //if mouse left button is clicked and gameStarted is false start game.
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            //function to move ball
            MoveBall();
        }
   
    }

 
    //on collisoin functioon
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        //if ball hit paddle of player 2
        if (collision2D.gameObject.name == "Player2")
        {
            //set top part of paddle so it will set the ball to jump downwords
            if (transform.position.y - collision2D.transform.position.y < -0.6)
            {
                //set the speed and direction of ball
                ball.velocity = new Vector2(-8f, -8f);
            }
            //set top part of paddle so it will set the ball to jump upwords
            else if (transform.position.y - collision2D.transform.position.y > 0.6)
            {
                //set the speed and direction of ball
                ball.velocity = new Vector2(-8f, 8f);
            }
        }
        //same thing to player 1 but oppiste side
        if (collision2D.gameObject.name == "Player1")
        {
            if (transform.position.y - collision2D.transform.position.y < -0.6)
            {
                ball.velocity = new Vector2(8f, -8f);
            }
            if (transform.position.y - collision2D.transform.position.y > 0.6)
            {
                ball.velocity = new Vector2(8f, 8f);

            }
      
        }

  
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ball.transform.position = new Vector3(0f, 0f,-5f);
        if (collision.gameObject.name == "Player1ScoreCollider")
        {

            score+=ScorePerGoal;
            Player1ScoreText.text =score.ToString();
        }
        if (collision.gameObject.name == "Player2ScoreCollider")
        {

            score += ScorePerGoal;
            Player2ScoreText.text = score.ToString();
        }



        MoveBall();

    }

    void MoveBall()
    {
       
        gameStarted = true;
        int xDirexction = Random.Range(0, 3);
        int yDirexction = Random.Range(0, 3);
        Vector2 launchBall = new Vector2();        
        if (xDirexction == 0)
        {
            launchBall.x = -8f;
        }
        else 
        {
            launchBall.x = 8f;
        }
        if (yDirexction == 0)
        {
            launchBall.y = 0f;
        }
        else if (yDirexction == 1)
        {
            launchBall.y = -8f;
        }
        else if (yDirexction == 2)
        {
            launchBall.y = 8f;
        }
        ball.velocity = launchBall;
    }
}





