using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Meter : MonoBehaviour{

    private int comboP2;

    private bool power1;
    private bool power2;
    private bool power3;

    private bool L2Pressed = false;
    private bool R2Pressed = false;

    private float powerLvl = 0f;
    float usedPower = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        comboP2 = GameObject.Find("Combo").GetComponent<Streak>().getComboP2();

        if (powerLvl >= 1.0f)
        {
            power1 = true;
            GameObject.Find("P2 Power1").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power1 = false;
            GameObject.Find("P2 Power1").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }

        if (powerLvl >= 2.0f)
        {
            power2 = true;
            GameObject.Find("P2 Power2").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power2 = false;
            GameObject.Find("P2 Power2").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }

        if (powerLvl >= 3.0f)
        {
            power3 = true;
            GameObject.Find("P2 Power3").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power3 = false;
            GameObject.Find("P2 Power3").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }

        //One press use all power for impulse push
        if (Input.GetButtonDown("P2R2"))
        {
            Debug.Log("Player 2 pressed R2");
            if (powerLvl <= 0f)
            {
                usedPower = 0f;
                return;
            }
            else
            {
                R2Pressed = true;
                usedPower = powerLvl;
                resetMeter();
            }
        }

        //One press use all power for jump
        if (Input.GetButtonDown("P2L2"))
        {
            Debug.Log("Player 2 pressed L2");
            if (powerLvl <= 0f)
            {
                usedPower = 0f;
                return;
            }
            else
            {
                L2Pressed = true;
                usedPower = powerLvl;
                resetMeter();
            }
        }
        else
        {
            L2Pressed = false;
        }

        /*
        //Could do: continue to press to use more power for jump
        if (Input.GetButton("P2L2"))
        {
            Debug.Log("Player 2 pressing L2");
            if (powerLvl - usedPower <= 0f)
            {
                return;
            }
            else
            {
                L2Pressed = true;
                //run animation for depleting power
                usedPower += Time.deltaTime;
            }
        } //Player let go, the powerlvl goes down
        else if (Input.GetButtonUp("P2L2"))
        {
            Debug.Log("Player 2 let go of  L2");
            powerLvl = powerLvl - Mathf.Ceil(usedPower);
            usedPower = 0f;
        }*/

    }

    public void powerUp()
    {
        //when combo equals to number
        if (comboP2 % 5 == 0 && comboP2 != 0)
        {
            powerLvl++;
        }
    }

    public void resetMeter()
    {
        power1 = false;
        power2 = false;
        power3 = false;
        powerLvl = 0f;
    }

    public float getPower()
    {
        //only return 0,1,2,3
        return Mathf.Ceil(usedPower);
    }

    public bool getL2Pressed()
    {
        return L2Pressed;
    }

    public bool getR2Pressed()
    {
        return R2Pressed;
    }
}
