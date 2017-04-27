using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    float timer = 3f;

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.transform.parent != null && other.transform.parent.CompareTag("Player"))
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            Destroy(GameObject.Find("Music Part"));
            Destroy(GameObject.Find("Players"));
            Destroy(GameObject.Find("Game Manager"));
            Destroy(GameObject.Find("Death Triggers"));

        }
    }
}
