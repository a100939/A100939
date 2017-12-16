using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerScene : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
    }
    public void LoadNewScene(string sceneName)// biex tarah funitu importanti li ikun PUBLIC
    {

        SceneManager.LoadScene(sceneName);
    }
    //Stop Game
    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
   

}