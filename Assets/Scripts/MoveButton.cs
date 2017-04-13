using UnityEngine;
using System.Collections;

public class MoveButton : MonoBehaviour {

    public float speed = 3f;
    public bool inRange;

    private float x;
    private float y;

    public bool? isHit = null;

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

        if (isHit == true)
        {
            speed = 0f;
            transform.position = new Vector3(x, 9.0f, 0);
        }
    }
}
