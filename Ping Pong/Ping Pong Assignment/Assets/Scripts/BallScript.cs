using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//used this for text
using UnityEngine.UI;
//For Scene chaning
using UnityEngine.SceneManagement;


public class BallScript : MonoBehaviour {
    //set name of varibale to change it to ball
    private Rigidbody2D ball;
    //set boolen to use later for game to start
    bool gameStarted = false;
    //set score text for player 1 & 2 will be displayed on the screen
    public Text Player1ScoreText;
    public Text Player2ScoreText;
    //set this for final score
    public Text Player1MaxScoreText;
    public Text Player2MaxScoreText;
    // End Scene Text
    public Text Player1WinText;
    public Text Player2WinText;
    //set score per goal 
    public int ScorePerGoal;
    //max score
    public int maxscore;
    //player one total score keep score
    public static int playerMaxscore1;
    //player two total score keep score
    public static int playerMaxscore2;
    //score per level
    public int score1;
    public int score2;





    // Use this for initialization
    void Start ()
    {
        //set varible to ball in game
        ball = GetComponent<Rigidbody2D>();

        //set postion of ball in center when starting the game
        ball.transform.position = new Vector3(0f, 0f, -5f);
        //set scores start 0
        score1 = 0;
        score2 = 0; 
        // score set to text
        Player1ScoreText.text = score1.ToString();
        Player2ScoreText.text = score2.ToString();



    }

   

    // Update is called once per frame
    void Update()
    {
        //text wont show
        Player1MaxScoreText.enabled = false;
        Player2MaxScoreText.enabled = false;
  

        //if scene is end
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("End"))
        {
            //if player 1 score is bigger then player 2 score
            if(playerMaxscore1>playerMaxscore2)
            //show player one score hide other scores
            Player1MaxScoreText.enabled = true;
            Player1WinText.enabled = true;
            Player1MaxScoreText.text = playerMaxscore1.ToString();
            Player2MaxScoreText.enabled = false;
            Player2WinText.enabled = false;
            Player1ScoreText.enabled = false;
            Player2ScoreText.enabled = false;
            //if player 2 score is bigger then player 1 score
            if (playerMaxscore2 > playerMaxscore1)
            {
                //show player two score hide other scores
                Player1MaxScoreText.enabled = false;
                Player1WinText.enabled = false;
                Player2MaxScoreText.text = playerMaxscore2.ToString();
                Player2MaxScoreText.enabled = true;
                Player2WinText.enabled = true;
                Player1ScoreText.enabled = false;
                Player2ScoreText.enabled = false;
            }
            // if scores are equal
            if(playerMaxscore1 == playerMaxscore2)
            {
                //show both scores
                Player1MaxScoreText.enabled = true;
                Player1WinText.enabled = true;
                Player1MaxScoreText.text = playerMaxscore1.ToString();
                Player2MaxScoreText.enabled = true;
                Player2WinText.enabled = true;
                Player2MaxScoreText.text = playerMaxscore2.ToString();
                Player1ScoreText.enabled = false;
                Player2ScoreText.enabled = false;
            }
    
        }

        //if game is false
        if (!gameStarted)
            //ball stays in center
            ball.transform.position = new Vector3(0f, 0f,-5f);
        //if mouse left button is clicked and gameStarted is false call ball move function.
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            //function to move ball
            MoveBall();
        }
        //mouse invisble
        Cursor.visible = false;
        //set varible for current scene
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        //if player 1 score or player 2 score reach max score
        if (score1 == maxscore || score2==maxscore)
        {
            //add one to current scene
            currentScene++;
            //load scene
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

    //on trigger function
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // set ball position to center
        ball.transform.position = new Vector3(0f, 0f,-5f);
        //if ball hits player 2 score area
        if (collision.gameObject.name == "Player1ScoreCollider")
        {
            //player one score increase per level
            score1+=ScorePerGoal;
            //player one score increase per game
            playerMaxscore1+=score1;
            //set score per level to text to be shown
            Player1ScoreText.text =score1.ToString();
         
        }
        //same thing as for player one
        if (collision.gameObject.name == "Player2ScoreCollider")
        {
            score2 += ScorePerGoal;
            playerMaxscore2+=score2;
            Player2ScoreText.text = score2.ToString();
       
        }
        //call function move ball
        MoveBall();
    }
    //ball movement
    void MoveBall()
    {
        //game is true
        gameStarted = true;
        //x direction random 3 posssiblties
        int xDirexction = Random.Range(0, 3);
        //y direction random 3 posssiblties
        int yDirexction = Random.Range(0, 3);
        //set varible to start ball
        Vector2 launchBall = new Vector2();      
        // if x is 0
        if (xDirexction == 0)
        {
            // ball goes left
            launchBall.x = -8f;
        }
        else 
        {
            //ball goese right
            launchBall.x = 8f;
        }
        //if y is 0
        if (yDirexction == 0)
        {
            //ball stays the same on the y axis
            launchBall.y = 0f;
        }
        //if y is 1
        else if (yDirexction == 1)
        {
            //ball goes down
            launchBall.y = -8f;
        }
        //if y is 2
        else if (yDirexction == 2)
        {
            //ball goes up
            launchBall.y = 8f;
        }
        //ball spped is same as ball direction
        ball.velocity = launchBall;
    }


}





