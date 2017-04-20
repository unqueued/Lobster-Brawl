using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Miss : MonoBehaviour {

    private Streak combo;

    // Use this for initialization
    void Start()
    {
        combo = GameObject.Find("Combo").GetComponent<Streak>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Check if button enter the empty bar and gets destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square" || other.gameObject.tag == "Circle" || other.gameObject.tag == "X")
        {
            if(other != null)
            {
                combo.P2Miss();
                Destroy(other.gameObject);
            }
        }
    }
}
