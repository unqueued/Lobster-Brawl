﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P1_Button : MonoBehaviour {

    private Streak combo;
    private Generator arr;
    private List<MoveButton> buttons1;
    private P1_Meter powerMeter;

    public Animator TriangleAnimations;
    public Animator SquareAnimations;
    public Animator CircleAnimations;
    public Animator XAnimations;
    public Animator ComboAnimations;

    // Use this for initialization
    void Start() {
        powerMeter = GameObject.Find("P1 Power Meter").GetComponent<P1_Meter>();
        combo = GameObject.Find("Combo").GetComponent<Streak>();
        arr = GameObject.Find("Generator").GetComponent<Generator>();
        buttons1 = arr.getList1();
	}
	
	// Update is called once per frame  
	void Update () {
        //Checks through the list if button is in/on the bar line and if the correct button is pressed
        if (buttons1 != null)
        {
            for (int i = 0; i < buttons1.Count; i++)
            {
                if (Input.GetButtonDown("P1Triangle"))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Triangle")
                        {
                            TriangleAnimations.Play("Triangle Hit");
                            combo.P1Hit();
                            powerMeter.powerUp();
                            Destroy(buttons1[i].gameObject);
                            return;                            
                        }
                        else if((buttons1[i].inRange == false && buttons1[i].tag == "Triangle") || (buttons1[i].inRange==true && buttons1[i].tag != "Triangle"))
                        {
                            combo.P1Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P1Square"))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Square")
                        {
                            SquareAnimations.Play("Square Hit");
                            combo.P1Hit();
                            powerMeter.powerUp();
                            Destroy(buttons1[i].gameObject);
                            return;
                        }
                        else if ((buttons1[i].inRange == false && buttons1[i].tag == "Square") || (buttons1[i].inRange == true && buttons1[i].tag != "Square"))
                        {
                            combo.P1Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P1Circle"))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "Circle")
                        {
                            CircleAnimations.Play("Circle Hit");
                            combo.P1Hit();
                            powerMeter.powerUp();
                            Destroy(buttons1[i].gameObject);
                            return;               
                        }
                        else if ((buttons1[i].inRange == false && buttons1[i].tag == "Circle") || (buttons1[i].inRange == true && buttons1[i].tag != "Circle"))
                        {
                            combo.P1Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P1X"))
                {
                    if (buttons1[i] != null)
                    {
                        if (buttons1[i].inRange == true && buttons1[i].tag == "X")
                        {
                            XAnimations.Play("X Hit");
                            combo.P1Hit();
                            powerMeter.powerUp();
                            Destroy(buttons1[i].gameObject);
                            return;
                        }
                        else if ((buttons1[i].inRange == false && buttons1[i].tag == "X") || (buttons1[i].inRange == true && buttons1[i].tag != "X"))
                        {
                            combo.P1Miss();
                        }
                    }
                }
            }//end of for loop
        }
    }
}
