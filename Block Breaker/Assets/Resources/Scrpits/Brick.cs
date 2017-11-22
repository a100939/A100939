using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Brick : MonoBehaviour {
    int timesHit;
    public static int breakableCount = 0;
    public int health;
    LevelManager levelManager = new LevelManager();
 

    AudioClip crack;

	// Use this for initialization
	void Start () {
        timesHit = 0;

        breakableCount++;
        print(breakableCount);
        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip; AudioListener.volume = 1.0F;
       
    }
	
	// Update is called once per frame
	void Update () {
     
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        health--; 
        print(gameObject.name + " : " + timesHit);

        AudioSource.PlayClipAtPoint(crack, this.transform.position);
        if (health <= 0)
        {
            // TestWin();
            breakableCount--;
            print(breakableCount);
            Destroy(gameObject);
        }

    }
    void TestWin()
    {
        levelManager.LoadNextScene();
    }

}
