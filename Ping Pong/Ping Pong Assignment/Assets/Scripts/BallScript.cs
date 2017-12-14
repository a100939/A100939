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
      

        this.transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)  // if(gameStarted = false
            this.transform.position = new Vector3(0f, 0f, 0f);
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            print("game stared");
            MoveBall();
       }
    
    
       

    }
    void onCollisionEnter2D(Collision2D hit)
    {
        float Player1Coll = this.transform.position.y - GameObject.Find("bat1").transform.position.y;
        print(Player1Coll);
        float Player2Coll = this.transform.position.y - GameObject.Find("bat2").transform.position.y;
        print(Player2Coll);

      
    }

        private void OnTriggerEnter2D(Collider2D collision)
    {

        this.transform.position = new Vector3(0f, 0f, 0f);
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





