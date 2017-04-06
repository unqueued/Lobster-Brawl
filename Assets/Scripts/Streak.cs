using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streak : MonoBehaviour {

    public static int hitStreak = 0;

    public Transform comboDisplay;

    public bool comboSpawn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((hitStreak == 5) && (comboSpawn == false))
        {
            comboSpawn = true;
            // Instantiate( combo picture goes here, new Vector3 (location goes here), 
        }
	}
}
