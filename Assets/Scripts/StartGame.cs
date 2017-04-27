using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour {

    float timer = 3f;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (timer <= 0f)
        {
            if (Input.GetButtonDown("P1X") || Input.GetButtonDown("P2X"))
            {
                SceneManager.LoadScene("round1", LoadSceneMode.Single);
            }
        }
        else
        {
            timer -= Time.deltaTime;
        }
	}
}
