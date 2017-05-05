using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Loading : MonoBehaviour {

    string[] arr = new string[5];
    int index;
    float wait = 0f;
    public Text text;

    // Use this for initialization
    void Start () {
        arr[0] = "Fill pot with water";/*
        arr[1] = "Boiling Water";
        arr[2] = "Place Lobster into water";
        arr[3] = "Check if lobster is cooked";
        arr[4] = "Plate the lobster";*/

		text = this.gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(wait < 0f)
        {
            wait -= Time.deltaTime;
        }
        else
        {
            if(index != 5)
            {
                text.text = arr[index];
                //index++;
                wait = 200000f;
            }
        }
	}
}
