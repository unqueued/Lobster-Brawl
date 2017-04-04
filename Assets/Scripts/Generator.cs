using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generator : MonoBehaviour {

    public MoveButton triangle;
    public MoveButton square;
    public MoveButton circle;
    public MoveButton x;

    float timer;
    List<MoveButton> buttons1 = new List<MoveButton>();
    List<MoveButton> buttons2 = new List<MoveButton>();

    // Use this for initialization
    void Start () {
        StartCoroutine(onCoroutine());
    }
	
    IEnumerator onCoroutine()
    {
        while (true)
        {
            Create();
            yield return new WaitForSeconds(0.7f);
        }
    }

	// Update is called once per frame
	//void Update () { 
    //    timer -= Time.deltaTime;
    //    if(timer <= 0)
    //    {
    //        Create();
    //        timer = 1f;
    //    }
    //}

    void Create()
    {
        int randNum = Random.Range(0, 4);
        MoveButton obj1 = null;
        MoveButton obj2 = null;

        if (randNum == 0)
        { 
            obj1 = (MoveButton)Instantiate(triangle, new Vector3(-19.67f, 3.04f, 0), Quaternion.identity);
            obj2 = (MoveButton)Instantiate(triangle, new Vector3(19.67f, 3.04f, 0), Quaternion.identity);
        }

        else if (randNum == 1)
        {
            obj1 = (MoveButton)Instantiate(square, new Vector3(-19.67f, 1.05f, 0), Quaternion.identity);
            obj2 = (MoveButton)Instantiate(square, new Vector3(19.67f, 1.05f, 0), Quaternion.identity);
        }

        else if (randNum == 2)
        {
            obj1 = (MoveButton)Instantiate(circle, new Vector3(-19.67f, -0.98f, 0), Quaternion.identity);
            obj2 = (MoveButton)Instantiate(circle, new Vector3(19.67f, -0.98f, 0), Quaternion.identity);
        }

        else if (randNum == 3)
        {
            obj1 = (MoveButton)Instantiate(x, new Vector3(-19.67f, -3.01f, 0), Quaternion.identity);
            obj2 = (MoveButton)Instantiate(x, new Vector3(19.67f, -3.01f, 0), Quaternion.identity);
        }

        buttons1.Add(obj1);
        buttons2.Add(obj2);
    }

    public List<MoveButton> getList1()
    {
        return buttons1;
    }

    public List<MoveButton> getList2()
    {
        return buttons2;
    }
}
