using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_Meter : MonoBehaviour {

    public int comboP1;
    private bool power1 = false;
    private bool power2 = false;
    private bool power3 = false;

    private bool L2Pressed = false;
    private bool R2Pressed = false;

    public float powerLvl = 0f;
    private float usedPower = 0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        comboP1 = GameObject.Find("Combo").GetComponent<Streak>().getComboP1();

        if (powerLvl >= 1.0f)
        {
            power1 = true;
            GameObject.Find("P1 Power1").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power1 = false;
            GameObject.Find("P1 Power1").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }
        
        if (powerLvl >= 2.0f)
        {
            power2 = true;
            GameObject.Find("P1 Power2").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power2 = false;
            GameObject.Find("P1 Power2").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }
        
        if (powerLvl >= 3.0f)
        {
            power3 = true;
            GameObject.Find("P1 Power3").GetComponent<SpriteRenderer>().color = new Color(255, 0, 0, 1);
        }
        else
        {
            power3 = false;
            GameObject.Find("P1 Power3").GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        }

        //One press use all power for impulse push
        if (Input.GetButtonDown("P1R2"))
        {
            Debug.Log("Player 1 pressed R2");
            if(powerLvl <= 0f)
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

        //Could do: continue to press to use more power for jump
        if (Input.GetButton("P1L2"))
        {
            Debug.Log("Player 1 pressing L2");
            if (powerLvl-usedPower <= 0f)
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
        else if (Input.GetButtonUp("P1L2"))
        {
            Debug.Log("Player 1 let go of L2");
            powerLvl = powerLvl-Mathf.Ceil(usedPower);
            usedPower = 0f;
        }

    }

    public void powerUp()
    {
        //when combo equals to number
        if (comboP1 % 5 == 0 && comboP1 != 0)
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
