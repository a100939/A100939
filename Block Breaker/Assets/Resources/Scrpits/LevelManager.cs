using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {
          

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Cursor.visible = true;
    }
    public void LoadNewScene(string sceneName)// biex tarah funitu importanti li ikun PUBLIC
    {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(sceneName);
    }
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void LoadNextScene()
    {
        Brick.breakableCount = 0;
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (Brick.breakableCount == 0)
        {
            currentScene++;
            SceneManager.LoadScene(currentScene);
        }
    }

}
