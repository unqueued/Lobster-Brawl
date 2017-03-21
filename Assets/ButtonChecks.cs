using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ButtonChecks : MonoBehaviour {

    public KeyCode keyT;
    public KeyCode keyF;
    public KeyCode keyG;
    public KeyCode keyH;

    public List<MoveButton> buttons = new List<MoveButton>();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame  
	void Update () {
        //Checks through the list if button is in/on the bar line and if the correct button is pressed
        for (int i = 0; i < buttons.Count; i++)
        {
            if (Input.GetKeyDown(keyT))
            {
                Debug.Log("Pressing T");
                if (buttons[i].inRange == true && buttons[i].tag == "ButtonT")
                {
                    Destroy(buttons[i].gameObject);
                }
            }

            if (Input.GetKeyDown(keyF))
            {
                Debug.Log("Pressing F");
                if (buttons[i].inRange == true && buttons[i].tag == "ButtonF")
                {
                    Destroy(buttons[i].gameObject);
                }
            }

            if (Input.GetKeyDown(keyG))
            {
                Debug.Log("Pressing G");
                if (buttons[i].inRange == true && buttons[i].tag == "ButtonG")
                {
                    Destroy(buttons[i].gameObject);
                }
            }

            if (Input.GetKeyDown(keyH))
            {
                Debug.Log("Pressing H");
                if (buttons[i].inRange == true && buttons[i].tag == "ButtonH")
                {
                    Destroy(buttons[i].gameObject);
                }
            }
        }//end of for loop
    }
}
