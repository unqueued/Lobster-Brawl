using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P1_Button : MonoBehaviour {

	/*
    public KeyCode triangle;
    public KeyCode square;
    public KeyCode circle;
    public KeyCode x;
    */

	public KeyCode triangle = KeyCode.E;
	public KeyCode square = KeyCode.R;
	public KeyCode circle = KeyCode.T;
	public KeyCode x = KeyCode.Y;


    /* for PS4 Controller
    private KeyCode triangle = KeyCode.Joystick2Button3;
    private KeyCode square = KeyCode.Joystick2Button0;
    private KeyCode circle = KeyCode.Joystick2Button2;
    private KeyCode x = KeyCode.Joystick2Button1;
    */

    public Generator arr;
    public List<MoveButton> buttons1;

    // Use this for initialization
    void Start () {
        buttons1 = arr.getList1();
	}
	
	// Update is called once per frame  
	void Update () {
        //Checks through the list if button is in/on the bar line and if the correct button is pressed
        if (buttons1 != null)
        {
            for (int i = 0; i < buttons1.Count; i++)
            {
                if (Input.GetKeyDown(triangle))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Triangle")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }
                    }
                }

                else if (Input.GetKeyDown(square))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Square")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }
                    }
                }

                else if (Input.GetKeyDown(circle))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Circle")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }
                    }
                }

                else if (Input.GetKeyDown(x))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "X")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }
                    }
                }
            }//end of for loop
        }
    }

    public List<MoveButton> getList()
    {
        return buttons1;
    }
}
