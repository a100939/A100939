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
        
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 10) - 5;
        mousePosInUnits = Mathf.Clamp(mousePosInUnits, -3.9f, 3.9f);

        Vector3 Player2Paddle = new Vector3(player2.transform.position.x, mousePosInUnits, player2.transform.position.z);
        player2.transform.position=Player2Paddle;
        //Cursor.visible = false;
    }

}
