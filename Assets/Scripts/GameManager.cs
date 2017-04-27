using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    //TimeStampe TextFile
    public TextAsset text1;
    //public TextAsset text2;
    private ReadText textFile;

    //Audio
    public AudioSource audio1;
    //public AudioSource audio2;
    private ReadSong soundFile;

    private int P1TopCombo;
    private int P2TopCombo;
    public Text P1Score;
    public Text P2Score;

    public bool time = true;
    public float timer = 2f;

    public enum level{
        lvl1,
        end
        //,lvl2
    };
    public level current;
    public bool end_pushed = false;
    public bool end = false;

    public bool player1Win = false;
    public bool player2Win = false;

	// Use this for initialization
	void Start () {
        textFile = GameObject.Find("TimeStamp").GetComponent<ReadText>();
        soundFile = GameObject.Find("TimeStamp").GetComponent<ReadSong>();
        current = level.lvl1;
    }

    // Update is called once per frame
    void Update() {

        P1TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP1();
        P2TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP2();

        P1Score.text = "Score " + P1TopCombo;
        P2Score.text = "Score " + P2TopCombo;

        if (timer > 0f && time)
        {
            timer -= Time.deltaTime;
        }

        if (current == level.lvl1 && timer <= 0f)
        {
            textFile.setText(text1);
            soundFile.setSong(audio1);
            time = false;
            timer = 2f;
        }
        else if (current == level.end && timer <= 0f)
        {
            time = false;
            timer = 2f;
            if (end_pushed)
            {
                if (player1Win)
                {
                    GameObject.Find("Winner").GetComponent<Text>().text = "Player 1 Wins";
                }
                else if (player2Win)
                {
                    GameObject.Find("Winner").GetComponent<Text>().text = "Player 2 Wins";
                }
            }
            else if(end)
            {
                if (P1TopCombo > P2TopCombo)
                {
                    GameObject.Find("Winner").GetComponent<Text>().text = "Player 1 Wins";
                }
                else if (P2TopCombo > P1TopCombo)
                {
                    GameObject.Find("Winner").GetComponent<Text>().text = "Player 2 Wins";
                }
            }
        }/*
        else if(current == level.lvl2 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text2);
            soundFile.setSong(audio2);
        }

        if (next == true)
        {
            if(current == level.lvl1)
            {
                SceneManager.LoadScene("round2", LoadSceneMode.Single);
                current = level.lvl2;
                next = false;
            }
            else if(current == level.lvl2)
            {
                next = false;
            }
        }*/
        
    }
}