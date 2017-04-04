using UnityEngine;
using System.Collections;

public class MoveButton : MonoBehaviour {

    float speed = 10f;
    public bool inRange;

    private float x;
    private float y;

    public bool hit;
    public bool miss;

    // Use this for initialization
    void Start () {
        x = transform.position.x;
        y = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        //Goes from their position to the center
        if(x > 0)
        {
            x -= speed * Time.deltaTime;
        }
        else if (x < 0)
        {
            x += speed * Time.deltaTime;
        }
        transform.position = new Vector3(x, y, 0);
    }
}
