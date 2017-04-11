using UnityEngine;
using System.Collections;

public class touchBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    //Check if button is touching bar line
    void OnTriggerStay2D(Collider2D other)
    {
        //other.transform.parent.tag = "Button";
        if(other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square" || other.gameObject.tag == "Circle" || other.gameObject.tag == "X")
        {
            //Debug.Log("inRange");
            other.gameObject.GetComponent<MoveButton>().inRange = true;
        }
    }

    //Check if button is not touching bar line anymore
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square" || other.gameObject.tag == "Circle" || other.gameObject.tag == "X")
        {
            //Debug.Log("not inRange");
            other.gameObject.GetComponent<MoveButton>().inRange = false;
        }
    }
}
