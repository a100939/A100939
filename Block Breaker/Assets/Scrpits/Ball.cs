using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle paddle;
    Vector3 paddleBallPosDiff;
    bool gameStarted = false;
	// Use this for initialization
	void Start () {
        paddleBallPosDiff = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)  // if(gameStarted = false
        this.transform.position = paddle.transform.position + paddleBallPosDiff;
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }


    }


}

