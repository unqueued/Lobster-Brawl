using UnityEngine;
using System.Collections;

public class MoveButton : MonoBehaviour {

    public float speed;
    public bool inRange;

    private float x;
    private float y;

    // Use this for initialization
    void Start () {
        x = transform.position.x;
        y = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        //Goes from their position to the center
        x -= transform.position.x * speed * Time.deltaTime;
        transform.position = new Vector3(x, y, 0);
    }
}
