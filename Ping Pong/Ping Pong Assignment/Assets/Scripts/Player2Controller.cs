using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    // set a private so only this scprit can see
    private Rigidbody2D player2;

    // Use this for initialization
    void Start()
    {
        //set player1 to player1paddle
        player2 = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.R))
        {
            player2.velocity = new Vector2(0f, 5f);
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.F))
        {
            player2.velocity = new Vector2(0f, -5f);
        }
        else
        {
            player2.velocity = new Vector2(0f, 0f);
        }
    }
}
