using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P2_Button : MonoBehaviour
{

    KeyCode triangle = KeyCode.Joystick1Button3;
    KeyCode square = KeyCode.Joystick1Button0;
    KeyCode circle = KeyCode.Joystick1Button2;
    KeyCode x = KeyCode.Joystick1Button1;

    public Generator arr;
    List<MoveButton> buttons2;

    // Use this for initialization
    void Start()
    {
        buttons2 = arr.getList2();
    }

    // Update is called once per frame  
    void Update()
    {
        //Checks through the list if button is in/on the bar line and if the correct button is pressed
        if (buttons2 != null)
        {
            for (int i = 0; i < buttons2.Count; i++)
            {
                if (Input.GetKey(triangle))
                {
                    //Debug.Log("Pressing triangle");
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Triangle")
                        {
                            buttons2[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons2[i].gameObject);
                            buttons2[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(square))
                {
                    //Debug.Log("Pressing square");
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Square")
                        {
                            buttons2[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons2[i].gameObject);
                            buttons2[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(circle))
                {
                    //Debug.Log("Pressing circle");
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Circle")
                        {
                            buttons2[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons2[i].gameObject);
                            buttons2[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }

                else if (Input.GetKey(x))
                {
                    //Debug.Log("Pressing x");
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "X")
                        {
                            buttons2[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons2[i].gameObject);
                            buttons2[i] = null;
                            Debug.Log("Hit");
                        }
                    }
                }
            }//end of for loop
        }
    }

    public List<MoveButton> getList()
    {
        return buttons2;
    }
}
