using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("P1X") || Input.GetButtonDown("P2X"))
        {
            SceneManager.LoadScene("intro screen", LoadSceneMode.Single);
            return;
        }
    }
}
