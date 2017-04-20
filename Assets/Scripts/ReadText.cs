using UnityEngine;
using System.Collections;

public class ReadText : MonoBehaviour
{
    private TextAsset textFile;
    private float[] timeStampArr;

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
        timeStampArr = new float[linesArr.Length];
        for (int i = 0; i < linesArr.Length; i++)
        {
            float num = Mathf.Floor(float.Parse(linesArr[i]) * 10) / 10;
            timeStampArr[i] = num;
        }
    }

    public void setText(TextAsset file)
    {
        textFile = file;
        Read();
    }

    public float[] getTimeStamp()
    {
        return timeStampArr;
    }
}