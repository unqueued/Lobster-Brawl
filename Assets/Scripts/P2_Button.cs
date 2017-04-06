using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P2_Button : MonoBehaviour
{

    public KeyCode triangle;
    public KeyCode square;
    public KeyCode circle;
    public KeyCode x;

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
                if (Input.GetKeyDown(triangle))
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
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(square))
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
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(circle))
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
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(x))
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
                            Streak.hitStreak += 1;
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
