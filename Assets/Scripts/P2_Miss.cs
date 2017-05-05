using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Miss : MonoBehaviour {

    private Streak combo;

    public Animator TriangleAnimations;
    public Animator SquareAnimations;
    public Animator CircleAnimations;
    public Animator XAnimations;
    public Animator ComboAnimations;

    // Use this for initialization
    void Start()
    {
        combo = GameObject.Find("Combo").GetComponent<Streak>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Check if button enter the empty bar and gets destroyed
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Triangle" || other.gameObject.tag == "Square" || other.gameObject.tag == "Circle" || other.gameObject.tag == "X")
        {
            if(other != null)
            {
                combo.P2Miss();
                Destroy(other.gameObject);

                if (other.gameObject.tag == "Triangle")
                {
                    TriangleAnimations.Play("Triangle Miss");
                }
                else if (other.gameObject.tag == "Square")
                {
                    SquareAnimations.Play("Square Miss");
                }
                else if (other.gameObject.tag == "Circle")
                {
                    CircleAnimations.Play("Circle Miss");
                }
                else if (other.gameObject.tag == "X")
                {
                    XAnimations.Play("X Miss");
                }
            }
        }
    }
}
