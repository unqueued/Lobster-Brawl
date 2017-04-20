using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P2_Button : MonoBehaviour{

    public Streak combo;
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
                if (Input.GetButtonDown("P2Triangle"))
                {
                    Debug.Log("Pressing triangle");
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Triangle")
                        {
                            combo.P2Hit();
                            Destroy(buttons2[i].gameObject);
                        }
                        else if (buttons2[i].inRange == true && buttons2[i].tag != "Triangle" || buttons2[i].inRange == false)
                        {
                            Debug.Log("Hitting Triangle, Button not Triangle");
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
                            combo.P2Hit();
                            Destroy(buttons2[i].gameObject);
                        }
                        else if (buttons2[i].inRange == true && buttons2[i].tag != "Square" || buttons2[i].inRange == false)
                        {
                            Debug.Log("Hitting Square, Button not Square");
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
                            combo.P2Hit();
                            Destroy(buttons2[i].gameObject);
                        }
                        else if (buttons2[i].inRange == true && buttons2[i].tag != "Circle" || buttons2[i].inRange == false)
                        {
                            Debug.Log("Hitting Circle, Button not Circle");
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
                            combo.P2Hit();
                            Destroy(buttons2[i].gameObject);
                        }
                        else if (buttons2[i].inRange == true && buttons2[i].tag != "X" || buttons2[i].inRange == false)
                        {
                            Debug.Log("Hitting X, Button not X");
                        }
                    }
                }
            }//end of for loop
        }
    }
}
