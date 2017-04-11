using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P2_Button : MonoBehaviour
{
    public Generator arr;
    public List<MoveButton> buttons2;

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
                if (buttons2[i] != null)
                {
                    if (Input.GetButtonDown("P2Triangle"))
                    {
                        Debug.Log("Pressing triangle");
                        if (buttons2[i] != null)
                        {
                            if (buttons2[i].inRange == true && buttons2[i].tag == "Triangle")
                            {
                                buttons2[i].GetComponent<MoveButton>().isHit = true;
                                buttons2[i].GetComponent<Renderer>().enabled = false;
                            }
                        }
                    }

                    else if (Input.GetButtonDown("P2Square"))
                    {
                        Debug.Log("Pressing square");
                        if (buttons2[i] != null)
                        {
                            if (buttons2[i].inRange == true && buttons2[i].tag == "Square")
                            {
                                buttons2[i].GetComponent<MoveButton>().isHit = true;
                                buttons2[i].GetComponent<Renderer>().enabled = false;
                            }
                        }
                    }

                    else if (Input.GetButtonDown("P2Circle"))
                    {
                        Debug.Log("Pressing circle");
                        if (buttons2[i] != null)
                        {
                            if (buttons2[i].inRange == true && buttons2[i].tag == "Circle")
                            {
                                buttons2[i].GetComponent<MoveButton>().isHit = true;
                                buttons2[i].GetComponent<Renderer>().enabled = false;
                            }
                        }
                    }

                    else if (Input.GetButtonDown("P2X"))
                    {
                        Debug.Log("Pressing x");
                        if (buttons2[i] != null)
                        {
                            if (buttons2[i].inRange == true && buttons2[i].tag == "X")
                            {
                                buttons2[i].GetComponent<MoveButton>().isHit = true;
                                buttons2[i].GetComponent<Renderer>().enabled = false;
                            }
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
