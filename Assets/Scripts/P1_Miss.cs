using UnityEngine;
using System.Collections;

public class P1_Miss : MonoBehaviour {

    private Streak combo;

    public Animator TriangleAnimations;
    public Animator SquareAnimations;
    public Animator CircleAnimations;
    public Animator XAnimations;
    public Animator ComboAnimations;

    // Use this for initialization
    void Start () {
        combo = GameObject.Find("Combo").GetComponent<Streak>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //Check if button enter the empty bar and gets destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square" || other.gameObject.tag == "Circle" || other.gameObject.tag == "X")
        {
            if(other != null)
            {
                combo.P1Miss();
                Destroy(other.gameObject);

                if (other.gameObject.tag == "Triangle")
                {
                    TriangleAnimations.Play("Triangle Miss");
                    //ComboAnimations.Play("Miss");
                }
                else if (other.gameObject.tag == "Square")
                {
                    SquareAnimations.Play("Square Miss");
                    //ComboAnimations.Play("Miss");
                }
                else if (other.gameObject.tag == "Circle")
                {
                    CircleAnimations.Play("Circle Miss");
                    //ComboAnimations.Play("Miss");
                }
                else if (other.gameObject.tag == "X")
                {
                    XAnimations.Play("X Miss");
                    //ComboAnimations.Play("Miss");
                }
            }
        }
    }
}
