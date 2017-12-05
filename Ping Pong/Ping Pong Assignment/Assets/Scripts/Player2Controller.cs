using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

    // set a private so only this scprit can see
    private Rigidbody2D player2;

    // Use this for initialization
    void Start()
    {
        //set player2 to player2paddle
        player2 = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false ;
        float mousePosInUnits = (Input.mousePosition.x / Screen.width * 16) - 8;

        Vector3 move = new Vector3(mousePosInUnits, this.transform.position.y,this.transform.position.z);
       
         move.y= Mathf.Clamp(mousePosInUnits,-6.5f,6.5f);
        this.transform.position = move; 
    }
   
}
