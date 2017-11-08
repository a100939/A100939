using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColliderScript : MonoBehaviour {
    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Coll");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        levelManager.LoadNewScene("Lose");
    }
}
