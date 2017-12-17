using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticaleMovement : MonoBehaviour {
    private Rigidbody2D obs;
    //obsticel goes up
    public static int obsSpeedUp =1;
    //goes down
    public static int obsSpeedDown = -1;
     //set varible
    public Vector3 obsDirectionUp = Vector3.up;
    public Vector3 obsDirectionDown = Vector3.down;


    // Use this for initialization
    void Start () {
        //attached to game object
        obs = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        // will start going up
        obs.transform.Translate(obsDirectionUp * obsSpeedUp * Time.deltaTime);
        //if x axis is greate or equal to 2.2
        if (obs.transform.position.x >= 2.2)
        {
            //will start going down
            obs.transform.Translate(obsDirectionDown * obsSpeedDown * Time.deltaTime);
        }
		
	}
}
