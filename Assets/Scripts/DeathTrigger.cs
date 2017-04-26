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
            if (timer <= 0f)
            {
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }
}
