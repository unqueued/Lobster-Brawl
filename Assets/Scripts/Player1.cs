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

    private bool isGrounded;

    private bool jump;

    [SerializeField]
    private float jumpForce;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        isGrounded = IsGrounded();

        HandleMovement(horizontal);

        Flip(horizontal);
    }

    private void HandleMovement(float horizontal)
    {
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space)) {
			//Debug.Log ("Space pushed");
			if (isGrounded) {
				Jump ();
			}
		}
		/*
        if(isGrounded && jump)
        {
            isGrounded = false;
            myRigidbody.AddForce(new Vector2(0, jumpForce));
        }
        */
    }

	/*
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }
    */

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

	public void Jump() {
		//Debug.Log ("Jump!");

		//Debug.Log (myRigidbody.velocity);

		//myRigidbody.AddForce(new Vector2(0, 30.5f));
		//myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);
		myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, myRigidbody.velocity.y + jumpHeight);

		//Debug.Log (myRigidbody.velocity);
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