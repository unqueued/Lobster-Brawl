using System.Collections;
using System.Collections.Generic;
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

    public enum level{
        lvl1
        //,lvl2
    };
    public level current;
    //public bool next = false;

	// Use this for initialization
	void Start () {
        textFile = GameObject.Find("TimeStamp").GetComponent<ReadText>();
        soundFile = GameObject.Find("TimeStamp").GetComponent<ReadSong>();
        current = level.lvl1;
    }
	
	// Update is called once per frame
	void Update () {
        P1TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP1();
        P2TopCombo = GameObject.Find("Combo").GetComponent<Streak>().getTopComboP2();

        P1Score.text = "Score " + P1TopCombo;
        P2Score.text = "Score " + P2TopCombo;

        if (current == level.lvl1 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text1);
            soundFile.setSong(audio1);
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