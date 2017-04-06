using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReadSong : MonoBehaviour {
    public AudioSource audio1;
    public ReadText timeStamp;
    public Generator generator;

    List<float> timeStampArr;
    int index = 0;

    // Use this for initialization
    void Start () {
        timeStampArr = timeStamp.getTimeStamp();
        audio1.Play();
	}
	
	// Update is called once per frame
	void Update () {
        if (audio1.isPlaying && timeStampArr.Count != index)
        {
            float time = (Mathf.Floor(audio1.time * 10) / 10) + 0.1f;
            if (timeStampArr[index] == time)
            {
                generator.make = true;
                index++;
            }
        }
    }
}
