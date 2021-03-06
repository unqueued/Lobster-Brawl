﻿using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    [SerializeField]
    private float movementSpeed = 1.5f;

    private bool facingRight;

    [SerializeField]
    private Transform[] groundPoints;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;

    private bool isGrounded;

    private bool jump;

    [SerializeField]
    private float jumpForce;

    private Streak streak;
    private P2_Meter powerMeter;

    void Start()
    {
        streak = GameObject.Find("Combo").GetComponent<Streak>();
        powerMeter = GameObject.Find("P2 Power Meter").GetComponent<P2_Meter>();
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Player2Horizontal");

        isGrounded = IsGrounded();

        HandleMovement(horizontal);

        //Flip(horizontal);

        if (streak.getComboP2() != 0){
            Debug.Log("Combo detected!");
            Impulse();
        }
    }

    private void HandleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

        if (isGrounded && jump)
        {
            isGrounded = false;
            myRigidbody.AddForce(new Vector2(0, jumpForce));
        }
    }

    private void HandleInput()
    {

		if (Input.GetKey (KeyCode.Alpha2)) {
			Impulse ();
		}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

	// Pushes player in direction that they are facing
	private void Impulse() {
		Debug.Log ("Impulse 2");
		if (facingRight) {
			myRigidbody.velocity = new Vector2 (2.5f, myRigidbody.velocity.y);
		}
		if(!facingRight) {
			myRigidbody.velocity = new Vector2 (-2.5f, myRigidbody.velocity.y);
		}
	}

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    private bool IsGrounded()
    {
        if (myRigidbody.velocity.y <= 0)
        {
            foreach (Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);
                for (int i = 0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject != gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}