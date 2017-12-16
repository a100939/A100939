using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//used this for text
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
    public int[] scorelist1 =  new int [3];
    public int[] scorelist2 = new int[3];
    public int maxscore;
    public int score1;
    public int score2;
    public int totalscore1;
    public int totalscore2;




    // Use this for initialization
    void Start ()
    {
        //set varible to ball in game
        ball = GetComponent<Rigidbody2D>();

        //set postion of ball in center when starting the game
        ball.transform.position = new Vector3(0f, 0f, -5f);
        score1 = 0;
        score2 = 0; 
        Player1ScoreText.text = score1.ToString();
        Player2ScoreText.text = score2.ToString();



    }

   

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("End"))
        {
            SceneManager.LoadScene("Start");
            Debug.Log("hello");
            print("Hello");
        }

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
        Cursor.visible = false;

        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (score1 == maxscore || score2==maxscore)
        {
            for (int i = 0; i < scorelist1.Length; i++)
            {
                score1 = totalscore1;
                scorelist1[i] = totalscore1;
            }
            for (int i = 0; i < scorelist2.Length; i++)
            {
                score2 = totalscore2;
                scorelist1[i] = totalscore2;
            }
            currentScene++;
            SceneManager.LoadScene(currentScene);
   
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
            score1+=ScorePerGoal;
            totalscore1 += score1;
            Player1ScoreText.text =score1.ToString();
            
        }
        if (collision.gameObject.name == "Player2ScoreCollider")
        {

            score2 += ScorePerGoal;
            Player2ScoreText.text = score2.ToString();
            
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





