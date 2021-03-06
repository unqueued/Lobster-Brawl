﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class P2_Button : MonoBehaviour{

    private Streak combo;
    private Generator arr;
    private List<MoveButton> buttons2;
    private P2_Meter powerMeter;

    public Animator TriangleAnimations;
    public Animator SquareAnimations;
    public Animator CircleAnimations;
    public Animator XAnimations;
    public Animator ComboAnimations;

    // Use this for initialization
    void Start()
    {
        powerMeter = GameObject.Find("P2 Power Meter").GetComponent<P2_Meter>();
        combo = GameObject.Find("Combo").GetComponent<Streak>();
        arr = GameObject.Find("Generator").GetComponent<Generator>();
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
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Triangle")
                        {
                            TriangleAnimations.Play("Triangle Hit");
                            combo.P2Hit();
                            powerMeter.powerUp();
                            Destroy(buttons2[i].gameObject);
                            return;
                        }
                        else if ((buttons2[i].inRange == false && buttons2[i].tag == "Triangle") || (buttons2[i].inRange == true && buttons2[i].tag != "Triangle"))
                        {
                            combo.P2Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P2Square"))
                {
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Square")
                        {
                            SquareAnimations.Play("Square Hit");
                            combo.P2Hit();
                            powerMeter.powerUp();
                            Destroy(buttons2[i].gameObject);
                            return;
                        }
                        else if ((buttons2[i].inRange == false && buttons2[i].tag == "Square") || (buttons2[i].inRange == true && buttons2[i].tag != "Square"))
                        {
                            combo.P2Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P2Circle"))
                {
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "Circle")
                        {
                            CircleAnimations.Play("Circle Hit");
                            combo.P2Hit();
                            powerMeter.powerUp();
                            Destroy(buttons2[i].gameObject);
                            return;
                        }
                        else if ((buttons2[i].inRange == false && buttons2[i].tag == "Circle") || (buttons2[i].inRange == true && buttons2[i].tag != "Circle"))
                        {
                            combo.P2Miss();
                        }
                    }
                }

                else if (Input.GetButtonDown("P2X"))
                {
                    if (buttons2[i] != null)
                    {
                        if (buttons2[i].inRange == true && buttons2[i].tag == "X")
                        {
                            XAnimations.Play("X Hit");
                            combo.P2Hit();
                            powerMeter.powerUp();
                            Destroy(buttons2[i].gameObject);
                            return;
                        }
                        else if ((buttons2[i].inRange == false && buttons2[i].tag == "X") || (buttons2[i].inRange == true && buttons2[i].tag != "X"))
                        {
                            combo.P2Miss();
                        }
                    }
                }
            }//end of for loop
        }
    }
}
