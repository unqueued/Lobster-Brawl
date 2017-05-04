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
    private ReadSong soundFile;

    private int P1TopCombo;
    private int P2TopCombo;
    private Text P1Score;
    private Text P2Score;

    public bool time = true;
    public float timer = 3f;

    public enum level{
        title,
        intro,
        tutorial,
        lvl1,
        end,
        intermission,
        victory,
        credits
        //,lvl2
    };
    public level current;
    public bool end_pushed = false;
    public bool end = false;

    public bool player1Win = false;
    public bool player2Win = false;

	// Use this for initialization
	void Start () {
        current = level.title;
    }

    // Update is called once per frame
    void Update() {

        //Update Score
        if (current == level.lvl1 && timer > 0f && time == false)
        {
            P1TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP1();
            P2TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP2();

            P1Score.text = "Score " + P1TopCombo;
            P2Score.text = "Score " + P2TopCombo;
        }

        if (timer > 0f && time)
        {
            timer -= Time.deltaTime;
        }

        if (current == level.title && timer <= 0f)
        {
            if (Input.GetButtonDown("P1X") || Input.GetButtonDown("P2X"))
            {
                SceneManager.LoadScene("intro screen", LoadSceneMode.Single);
                current = level.intro;
                timer = 0.5f;
                return;
            }
        }
        else if (current == level.intro && timer <= 0f)
        {
            if (Input.GetButtonDown("P1X") || Input.GetButtonDown("P2X"))
            {
                SceneManager.LoadScene("tutorial", LoadSceneMode.Single);
                current = level.tutorial;
                timer = 0.5f;
                return;
            }
        }
        else if (current == level.tutorial && timer <= 0f)
        {
            if (Input.GetButtonDown("P1X") || Input.GetButtonDown("P2X"))
            {
                SceneManager.LoadSceneAsync("round1", LoadSceneMode.Single);
                current = level.lvl1;
                timer = 1f;
                return;
            }
        }
        else if (current == level.lvl1 && timer <= 0f)
        {
            AudioSource audio = GameObject.Find("BrazilSamba").GetComponent<AudioSource>();
            textFile = GameObject.Find("TimeStamp").GetComponent<ReadText>();
            soundFile = GameObject.Find("TimeStamp").GetComponent<ReadSong>();
            textFile.setText(text1);
            soundFile.setSong(audio);
            P1Score = GameObject.Find("P1 Score").GetComponent<Text>();
            P2Score = GameObject.Find("P2 Score").GetComponent<Text>();
            time = false;
            timer = 2f;
            return;
        }
        else if (current == level.end && timer <= 0f)
        {
            if (end_pushed)
            {
                if (player1Win)
                {
                    SceneManager.LoadScene("victoryforplayer1", LoadSceneMode.Single);
                }
                else if (player2Win)
                {
                    SceneManager.LoadScene("victoryforplayer2", LoadSceneMode.Single);
                }
            }
            else if (end)
            {
                if (P1TopCombo > P2TopCombo)
                {
                    SceneManager.LoadScene("victoryforplayer1", LoadSceneMode.Single);
                }
                else if (P2TopCombo > P1TopCombo)
                {
                    SceneManager.LoadScene("victoryforplayer2", LoadSceneMode.Single);
                }
            }
            timer = 5f;
            current = level.intermission;
        }
        else if (current == level.intermission && timer <= 0f)
        {
            SceneManager.LoadScene("intermission", LoadSceneMode.Single);
            current = level.victory;
            timer = 10f;
            if(timer == 3f)
            {
                SceneManager.LoadSceneAsync("victory screen", LoadSceneMode.Single);
            }
        }
        else if (current == level.victory && timer <= 0f)
        {
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
            else if (end)
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
            current = level.credits;
            timer = 2f;
        }
        else if (current == level.credits && timer <= 0f)
        {
            SceneManager.LoadScene("credits",LoadSceneMode.Single);
            timer = 10f;
            current = level.title;
        }
        /*
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