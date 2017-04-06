using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReadText : MonoBehaviour {

    public TextAsset textFile;
    List<float> timeStampArr = new List<float>();

    // Use this for initialization
    void Start()
    {
        Read();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Read()
    {
        var linesArr = textFile.text.Split('\n');
        for (int i = 0; i < linesArr.Length; i++)
        {
            timeStampArr.Add(float.Parse(linesArr[i]));
        }
    }

    void setText(TextAsset file)
    {
        textFile = file;
    }

    public List<float> getTimeStamp()
    {
        return timeStampArr;
    }
}
