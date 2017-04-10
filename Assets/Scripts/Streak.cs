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

    public P1_Button listP1;
    public List<MoveButton> hitListP1;

    public P2_Button listP2;
    public List<MoveButton> hitListP2;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        hitListP1 = listP1.getList();
        hitListP2 = listP2.getList();
        for(int i = 0; i < hitListP1.Count; i++)
        {
            if (hitListP1[i].isHit == null)
            {
                break;
            }
            else if (hitListP1[i].isHit == true)
            {
                Debug.Log("HIT");
                comboP1++;
            }
            else
            {
                Debug.Log("Miss");
                int temp = comboP1;
                if(temp > topComboP1)
                {
                    topComboP1 = temp;
                }
                comboP1 = 0;
            }
            if (hitListP2[i].isHit == null)
            {
                break;
            }
            else if (hitListP2[i].isHit == true)
            {
                comboP2++;
            }
            else
            {
                int temp = comboP2;
                if(temp > topComboP2)
                {
                    topComboP2 = temp;
                }
                comboP2 = 0;
            }
        }
        if (((comboP1 == 5) || (comboP2 == 5))&& (comboSpawn == false))
        {
            comboSpawn = true;
            // Instantiate( combo picture goes here, new Vector3 (location goes here), 
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
