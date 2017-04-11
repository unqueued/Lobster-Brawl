using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReadSong : MonoBehaviour
{
    private AudioSource playingAudio;
    private bool play;

    public Generator generator;
    public ReadText timeStamp;
    public List<float> timeStampArr;
    int index = 0;

    // Use this for initialization
    void Start()
    {
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
            if (playingAudio.isPlaying && timeStampArr.Count != index)
            {
                float time = (Mathf.Floor(playingAudio.time * 10) / 10) + 0.1f;
                if (timeStampArr[index] == time)
                {
                    //Debug.Log(timeStampArr[index] + "--" + time);
                    generator.make = true;
                    index++;
                }
            }
            else if (playingAudio.isPlaying == false)
            {
                play = false;
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