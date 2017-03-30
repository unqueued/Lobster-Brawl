using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator : MonoBehaviour {

    public MoveButton bT;
    public MoveButton bF;
    public MoveButton bG;
    public MoveButton bH;

    public MoveButton bI;
    public MoveButton bJ;
    public MoveButton bK;
    public MoveButton bL;

    float timer;
    List<MoveButton> buttons;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () { 
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Create();
            timer = 1f;
        }
    }

    void Create()
    {
	//temporary, Akash recommend checking out Adobe Soundbooth to mark the timecode
	//make it into an array and use a loop coroutine to spawn the buttons 
        int randNum = Random.Range(0, 4);
        if (randNum == 0)
        { 
            buttons.Add((MoveButton)Instantiate(bT, new Vector3(-19.67f, 3.04f, 0), Quaternion.identity));
            buttons.Add((MoveButton)Instantiate(bI, new Vector3(19.67f, 3.04f, 0), Quaternion.identity));
        }

        else if (randNum == 1)
        {
            buttons.Add((MoveButton)Instantiate(bF, new Vector3(-19.67f, 1.05f, 0), Quaternion.identity));
            buttons.Add((MoveButton)Instantiate(bJ, new Vector3(19.67f, 1.05f, 0), Quaternion.identity));
        }

        else if (randNum == 2)
        {
            buttons.Add((MoveButton)Instantiate(bG, new Vector3(-19.67f, -0.98f, 0), Quaternion.identity));
            buttons.Add((MoveButton)Instantiate(bK, new Vector3(19.67f, -0.98f, 0), Quaternion.identity));
        }

        else if (randNum == 3)
        {
            buttons.Add((MoveButton)Instantiate(bH, new Vector3(-19.67f, -3.01f, 0), Quaternion.identity));
            buttons.Add((MoveButton)Instantiate(bL, new Vector3(19.67f, -3.01f, 0), Quaternion.identity));
        }
    }

    public List<MoveButton> getList()
    {
        return buttons;
    }
}
