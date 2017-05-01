using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ReadSong : MonoBehaviour
{
    private AudioSource playingAudio;
    private bool play;

    private GameManager manager;
    private Generator generator;
    private ReadText timeStamp;
    private float[] timeStampArr;
    int index = 0;

    // Use this for initialization
    void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        generator = GameObject.Find("Generator").GetComponent<Generator>();
        timeStamp = GameObject.Find("TimeStamp").GetComponent<ReadText>();
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            playingAudio.Play();
            play = false;
        }

        if (playingAudio != null)
        {
            if (playingAudio.isPlaying && timeStampArr.Length != index)
            {
                float time = (Mathf.Floor(playingAudio.time * 10) / 10) + 0.1f;
                if (timeStampArr[index] == time)
                {
                    generator.make = true;
                    index++;
                }
                if(time > (timeStampArr[index] + 1000f)){
                    playingAudio.Stop();
                }
                Debug.Log(time + " -- " + timeStampArr[index]);
            }
            else if (playingAudio.isPlaying == false)
            {
                play = false;
                manager.end = true;
                manager.time = true;
                manager.current = GameManager.level.end;
                SceneManager.LoadScene("victory screen", LoadSceneMode.Single);
                Destroy(GameObject.Find("Music Part"));
                Destroy(GameObject.Find("Players"));
                Destroy(GameObject.Find("Death Triggers"));
            }
        }
    }

    public void setSong(AudioSource file)
    {
        playingAudio = file;
        timeStampArr = timeStamp.getTimeStamp();
        play = true;
    }
}