using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streak : MonoBehaviour {

    public int comboP1 = 0;
    public int topComboP1 = 0;

    public int comboP2 = 0;
    public int topComboP2 = 0;

    public Transform comboDisplay;

    public bool comboSpawn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((comboP1 == 5 || comboP2 == 5) && comboSpawn == false)
        {
            comboSpawn = true;
            // Instantiate( combo picture goes here, new Vector3 (location goes here), 
        }
	}

    public void P1Miss()
    {
        comboP1 = 0;
    }

    public void P2Miss()
    {
        comboP2 = 0;
    }

    public void P1Hit()
    {
        comboP1++;
        if(comboP1 > topComboP1)
        {
            topComboP1 = comboP1;
        }
    }

    public void P2Hit()
    {
        comboP2++;
        if (comboP2 > topComboP2)
        {
            topComboP2 = comboP2;
        }
    }

    public int getComboP1()
    {
        return comboP1;
    }

    public int getComboP2()
    {
        return comboP2;
    }
    
    public int getTopComboP1()
    {
        return topComboP1;
    }

    public int getTopComboP2()
    {
        return topComboP2;
    }
}
