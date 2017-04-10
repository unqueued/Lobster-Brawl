using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ReadText : MonoBehaviour
{
    private TextAsset textFile;
    List<float> timeStampArr = new List<float>();

    // Use this for initialization
    void Start()
    {
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
            float num = Mathf.Floor(float.Parse(linesArr[i]) * 10) / 10;
            timeStampArr.Add(num);
        }
    }

    public void setText(TextAsset file)
    {
        textFile = file;
        Read();
    }

    public List<float> getTimeStamp()
    {
        return timeStampArr;
    }
}