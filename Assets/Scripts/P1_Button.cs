using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P1_Button : MonoBehaviour {

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
                if (buttons1[i] != null)
                {
                    if (Input.GetButtonDown("P1Triangle"))
                    {
                        Debug.Log("Triangle");
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Triangle")
                        {

                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }
                    }

                    else if (Input.GetButtonDown("P1Square"))
                    {
                        Debug.Log("Square");
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Square")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }

                    }

                    else if (Input.GetButtonDown("P1Circle"))
                    {
                        Debug.Log("Circle");
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Circle")
                        {
                            buttons1[i].GetComponent<MoveButton>().isHit = true;
                            buttons1[i].GetComponent<Renderer>().enabled = false;
                        }

                    }

                    else if (Input.GetButtonDown("P1X"))
                    {
                        Debug.Log("X");
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
