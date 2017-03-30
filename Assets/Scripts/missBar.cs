using UnityEngine;
using System.Collections;

public class missBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Check if button enter the empty bar and gets destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ButtonF" || other.gameObject.tag == "ButtonT" || other.gameObject.tag == "ButtonG" || other.gameObject.tag == "ButtonH")
        {
            //Debug.Log("Empty Bar");
            //Destroy(other.gameObject);
        }
    }
}
