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
        if(other.gameObject.tag == "ButtonF" || other.gameObject.tag == "ButtonT" || other.gameObject.tag == "ButtonG" || other.gameObject.tag == "ButtonH")
        {
            Debug.Log("inRange");
            other.gameObject.GetComponent<MoveButton>().inRange = true;
        }
    }

    //Check if button is not touching bar line anymore
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "ButtonF" || other.gameObject.tag == "ButtonT" || other.gameObject.tag == "ButtonG" || other.gameObject.tag == "ButtonH")
        {
            Debug.Log("not inRange");
            other.gameObject.GetComponent<MoveButton>().inRange = false;
        }
    }
}
