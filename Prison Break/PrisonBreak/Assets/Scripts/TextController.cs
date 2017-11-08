using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    public Text myText;
    enum States { cell,sheets_0,mirror,lock_0,cell_mirror,sheets_1,lock_1,freedom,corridor_0,stairs_0,floor,closet_door,stairs_1,corridor_1,in_closet,stairs_2,corridor_2,courtyard,corridor_3};
    States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
    //call the methods
	void Update () {
        if (myState == States.cell)
        {
            Cell();
        }
        else if (myState == States.sheets_0)
        {
            Sheets_0();
        }
        else if (myState == States.lock_0)
        {
            Lock_0();
        }
        else if (myState == States.mirror)
        {
            Mirror();
        }
        else if (myState == States.cell_mirror)
        {
            Cell_Mirror();
        }
        else if (myState == States.sheets_1)
        {
            Sheets_1();
        }
        else if (myState == States.lock_1)
        {
            Lock_1();
        }
        else if (myState == States.freedom)
        {
            Freedom();
        }
        else if (myState == States.corridor_0)
        {
            Corridor_0();
        }
        else if (myState == States.stairs_0)
        {
            Stairs_0();
        }
        else if (myState == States.floor)
        {
            Floor();
        }

    }
    //Start of the game will tell you what to do where to go
    void Cell()
    {
        myText.text = "You are in a prison cell, and you want to " +
      "escape. There are some dirty sheets on the bed, a" +
      " mirror on the wall, and the" +
      " door is locked from outside\n\n" +
      "Press S to view the sheets, M to view the mirror," +
      " L to view the lock. ";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }
    // if you press S
    void Sheets_0()
    {
        myText.text = "These sheets are very dirty! They really need to be changed!\n\n" + "" +
            "Press R to return back to the middle of the cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    //If you press L
    void Lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the combination is." +
            "You wish you could somehow see where the dirty fingerprints were on the buttons." +
            "\n\nPress R to return back to the middle of the cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    //if you press M
    void Mirror()
    {
        myText.text = "The dirty old mirror on the wall seems loose.\n\n" +
            "Press T to take the mirror, R to return back to the cell.";
        if (Input.GetKeyDown(KeyCode.T))
        {
            myState = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }
    //Went to the second cell
    void Cell_Mirror()
    {
        myText.text = "You are still in your cell and you STILL want to escape! There are some dirty sheets " +
            "On the bed, a mark where the mirror was and the door which is still firmly lock.\n\n" +
            "Press S to view the sheets, L to view the Lock.";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L)){
            myState = States.lock_1;
        }
    }
    //Seconds sheets
    void Sheets_1()
    {
        myText.text = "Holding a mirror in your hand, won't make the sheets look any better!\n\n" +
            "Press R to return to the middle of the cell!";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
    }
    //Second lock you can free your self 
    void Lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round so you can see the " +
            "lock. You can see where the fingerprints are on the dirty buttons. You press on the dirty buttons " +
            "and hear a click.\n\n" +
            "Press O to open the cell door, R to return to the cell.";
        if (Input.GetKeyDown(KeyCode.O))
        {
            myState = States.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }
       
    }
    //Corriodr 3 ways you can go
    void Corridor_0()
    {
        myText.text = "You are in the corridor you have 3 options where you can go.\n\n " +
            "You can go to the Stairs by pressing S, F to go to the Floor and C to go to the Closet";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.F)){
            myState = States.floor;
        }
        else if (Input.GetKeyDown(KeyCode.C)){
            myState = States.closet_door;
        }
    }
    //stairs_0 stage
    void Stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
            "You realise it's not break time, and you'll be caught immediately. " +
            "You slither back down the stairs and reconsider.\n\n" +
            "Press R to go back to corriodr";
 
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.corridor_0;
        }
    }
    // floor stage
    void Floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
            "Press P to pick up the hairclip " +
            "Press N to continue walking trough the corridor. ";


        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.corridor_0;
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.corridor_1;
        }
    }


    //closet door
    void ClosetDoor()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
            "Maybe you could find something around to help enourage it open?\n\n"+
            "Press B to return ";
       
        if
    }
    //Stop or play again
    void Freedom()
    {
        myText.text = "You are Finallay FREE HURAY!!\n\n" +
            "Press P to Play Again, Q to Quit";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
