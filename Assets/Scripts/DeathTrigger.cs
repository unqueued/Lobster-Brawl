using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
		// Update to tags for each player instead of just Player
		if (other.transform.parent != null && other.transform.parent.CompareTag ("Player")) {
			SceneManager.LoadScene("Button", LoadSceneMode.Single);
		}
    }
}
