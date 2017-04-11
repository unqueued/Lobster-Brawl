using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public TextAsset text1;
    public TextAsset text2;
    public ReadText textFile;
    public AudioSource audio1;
    public AudioSource audio2;
    public ReadSong soundFile;
    public Streak combo;

    public enum level{
        lvl1,
        lvl2,
        end
    };
    public level current;
    public bool next = false;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {

        if (current == level.lvl1 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text1);
            soundFile.setSong(audio1);
        }/*
        else if(current == level.lvl2 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text2);
            soundFile.setSong(audio2);
        }*/

        if(current == level.end)
        {
            
            if (combo.getTopComboP1() > combo.getTopComboP2())
            {
                Debug.Log("Player 1 Wins");
            }
            else if (combo.getTopComboP1() < combo.getTopComboP2())
            {
                Debug.Log("Player 2 Wins");
            }
        }

        if (next == true)
        {
            if (current == level.lvl1)
            {
                //SceneManager.LoadScene("round2", LoadSceneMode.Single);
                //current = level.lvl2;
                next = false;
            }/*
            else if(current == level.lvl2)
            {
                next = false;
            }*/
        }
    }
}