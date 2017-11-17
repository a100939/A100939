using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    int timesHit;
    public int health;
    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
     
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        health--; 
        print(gameObject.name + " : " + timesHit);
        if (health <= 0)
        {
           // TestWin();
            Destroy(gameObject);
        }

    }
    void TestWin()
    {
        levelManager.LoadNextScene();
    }

}
