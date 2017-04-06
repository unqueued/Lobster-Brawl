using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P1_Button : MonoBehaviour {

    KeyCode triangle = KeyCode.Joystick2Button3;
    KeyCode square = KeyCode.Joystick2Button0;
    KeyCode circle = KeyCode.Joystick2Button2;
    KeyCode x = KeyCode.Joystick2Button1;

    public Generator arr;
    List<MoveButton> buttons1;

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
                if (Input.GetKey(triangle))
                {
                    //Debug.Log("Pressing triangle");
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Triangle")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(square))
                {
                    //Debug.Log("Pressing square");
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Square")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(circle))
                {
                    //Debug.Log("Pressing circle");
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Circle")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(x))
                {
                    //Debug.Log("Pressing x");
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "X")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Debug.Log("Hit");
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
