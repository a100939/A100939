using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour {
    // set a private so only this scprit can see
    private Rigidbody2D player1;

	// Use this for initialization
	void Start () {
        //set player1 to player1paddle
        player1 = this.GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow))
        {
            player1.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player1.velocity = new Vector2(0f, -5f);
        }
        else
        {
            player1.velocity = new Vector2(0f, 0f);
        }
	}
}
