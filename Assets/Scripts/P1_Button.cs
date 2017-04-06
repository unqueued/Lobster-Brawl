using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P1_Button : MonoBehaviour {

    public KeyCode triangle;
    public KeyCode square;
    public KeyCode circle;
    public KeyCode x;

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
                if (Input.GetKeyDown(triangle))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Triangle")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(square))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Square")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(circle))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Circle")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Streak.hitStreak += 1;
                        }
                    }
                }

                else if (Input.GetKeyDown(x))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "X")
                        {
                            buttons1[i].GetComponent<MoveButton>().hit = true;
                            Destroy(buttons1[i].gameObject);
                            buttons1[i] = null;
                            Streak.hitStreak += 1;
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
