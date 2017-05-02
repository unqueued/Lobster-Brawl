using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {

    //float timer = 3f;

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.transform.parent != null && other.transform.parent.CompareTag("Player"))
        {
            if(other.gameObject.name == "Player 1")
            {
                GameObject.Find("Game Manager").GetComponent<GameManager>().player2Win = true;
            }
            else if(other.gameObject.name == "Player 2")
            {
                GameObject.Find("Game Manager").GetComponent<GameManager>().player1Win = true;
            }

            Destroy(GameObject.Find("Music Part"));
            Destroy(GameObject.Find("Players"));
            Destroy(GameObject.Find("Death Triggers"));
            GameObject.Find("Game Manager").GetComponent<GameManager>().end_pushed = true;
            GameObject.Find("Game Manager").GetComponent<GameManager>().time = true;
            GameObject.Find("Game Manager").GetComponent<GameManager>().current = GameManager.level.end;
        }
    }
}
