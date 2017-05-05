using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading_circle : MonoBehaviour {

    private Transform trans;

    // Use this for initialization
    void Start () {
        trans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        trans.Rotate(0, 0, -60 * Time.fixedDeltaTime);
    }
}
