using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    [SerializeField]
    private float movementSpeed = 1.5f;

    private float jumpHeight = 10.0f;

    private bool facingRight;

    [SerializeField]
    private Transform[] groundPoints;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;

    private bool jump;

    [SerializeField]
    private float jumpForce;

	public Streak streak;

    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("P1Horizontal");

        //isGrounded = IsGrounded();

        HandleMovement(horizontal);

        //Flip(horizontal);

		//Debug.Log (streak.getComboP1 ());
		if (streak.getComboP1 () != 0) {
			Debug.Log ("Combo detected!");
			Impulse ();
		}
    }

    private void HandleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

		if (Input.GetKey (KeyCode.Alpha1)) {
			Impulse ();
		}
			

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log ("Space detected");
            if (IsGrounded())
            {
                Jump();
            }
            else
            {
                //Debug.Log ("Did not jump, because no grounded");
            }
        }
    }

	// Pushes player in direction that they are facing
	private void Impulse() {
		Debug.Log ("Impulse");
		if (facingRight) {
			myRigidbody.velocity = new Vector2 (-2.5f, myRigidbody.velocity.y);
		}
		if(!facingRight) {
			myRigidbody.velocity = new Vector2 (2.5f, myRigidbody.velocity.y);
		}
	}

    private void Flip(float horizontal)
    {
        if (horizontal < 0 && !facingRight || horizontal > 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }

    public void Jump()
    {
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y + jumpHeight);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        //Debug.Log ("Collision detected, tag: " + coll.gameObject.tag);
        //if (coll.gameObject.tag == "Enemy")
        //	coll.gameObject.SendMessage ("ApplyDamage", 10);

        // Make players bounce off each other on contact
        if (coll.gameObject.tag == "Player2")
        {
            //Rigidbody2D otherRigidBody2D = coll.gameObject.GetComponent<Rigidbody2D>();

            Debug.Log("Collision:");

            Debug.Log("Before: " + myRigidbody.position + " " + myRigidbody.velocity);

            myRigidbody.velocity = new Vector2(
                //-(myRigidbody.velocity.x * 5),
                //-50,
                myRigidbody.velocity.x,
                10
            //myRigidbody.velocity.y
            );

            Debug.Log("After: " + myRigidbody.position + " " + myRigidbody.velocity);

            //Debug.Log (otherRigidBody2D.position);
            //otherRigidBody2D.position.x -= 10;
            //Debug.Log (otherRigidBody2D.position);

            /*
			Debug.Log ("before: " + otherRigidBody2D.velocity);
			otherRigidBody2D.velocity = new Vector2(
				otherRigidBody2D.velocity.x - 10,
				otherRigidBody2D.velocity.y + jumpHeight
			);
			Debug.Log ("after: " + otherRigidBody2D.velocity);
			*/
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