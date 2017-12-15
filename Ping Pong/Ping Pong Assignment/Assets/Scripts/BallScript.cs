using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallScript : MonoBehaviour {
    private Rigidbody2D ball;
    bool gameStarted = false;
  
    // Use this for initialization
    void Start ()
    {
        ball = GetComponent<Rigidbody2D>();
      

        ball.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)  // if(gameStarted = false
            ball.transform.position = new Vector3(0f, 0f, 0f);
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
              
            if (ball.transform.position.x <-6.47f)
            {
                ScoreManager.instance.Player1ScoreMain();
                
            }
            if (ball.transform.position.x >6.47f)
            {
                ScoreManager.instance.Player2ScoreMain();
               
            }
            MoveBall();
        }
    
    
        

    }

 

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.name == "UpCollider")
        {
            ball.velocity = new Vector2(ball.velocity.x,ball.velocity.y*1f);
        }
        if (collision2D.gameObject.name == "DownCollider")
        {
            ball.velocity = new Vector2(ball.velocity.x, ball.velocity.y *1f);
   
        }
            
   
            if (collision2D.gameObject.name == "Player2")
            ball.velocity = new Vector2(-8f, 0f);
        {
            if (transform.position.y - collision2D.transform.position.y < -0.6)
            {
                ball.velocity = new Vector2(-8f, -8f);
            }
            else if (transform.position.y - collision2D.transform.position.y > 0.6)
            {
                ball.velocity = new Vector2(-8f, 8f);
            }
        }
        if (collision2D.gameObject.name == "Player1")
        {
            ball.velocity = new Vector2(8f, 0f);

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
        ball.transform.position = new Vector3(0f, 0f, 0f);
        Update();
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





