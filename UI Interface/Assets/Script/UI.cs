using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text myText;
    public InputField input;
    System.Random rnd = new System.Random();
    int rand1;
    int rand2;
   

    // Use this for initialization
    void Start () {
        Random();

     

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Random()
    {
        rand1 = rnd.Next(1, 11);
        rand2 = rnd.Next(1, 11);
        myText.text = "What is the sum of "+rand1+'x'+rand2+'?';


    }
   public void Ans()
    {
        int num = System.Convert.ToInt32(input.text);
        int sum = rand1 * rand2;
        if (sum == num)
        {
            Random();
            print("Good");
            myText.text = "";

        }
        else
        {
            print("Bad");
            Ans();
        }
      
  

    }

}
