using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public TextAsset text1;
    public TextAsset text2;
    public ReadText textFile;
    public AudioSource audio1;
    public AudioSource audio2;
    public ReadSong soundFile;

    public enum level{
        lvl1,
        lvl2
    };
    public level current;

	// Use this for initialization
	void Start () {
        //current = level.lvl1;
    }
	
	// Update is called once per frame
	void Update () {
        if(current == level.lvl1 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text1);
            soundFile.setSong(audio1);
        }
        else if(current == level.lvl2 && Input.GetKeyDown(KeyCode.Return))
        {
            textFile.setText(text2);
            soundFile.setSong(audio2);
        }
	}
}