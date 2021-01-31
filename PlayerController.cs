using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	private float speed = 5f;

	private bool facingRight = true;
	private Animator anim;
	bool grounded = true;

	[SerializeField]

	public Rigidbody2D myP { get; set; }

	void Start()
	{
		GetComponent<Rigidbody2D>().freezeRotation = true;
		myP = GetComponent<Rigidbody2D>();
		anim = GetComponentInChildren<Animator>();
	}

	void Update()
	{

	}

	void FixedUpdate()
	{
		anim.SetBool("Ground", true);

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		if (horizontal > 0 || horizontal < 0)
		{
			anim.SetFloat("Speed", Mathf.Abs(horizontal));
		}
		else if (vertical > 0 || vertical < 0)
		{
			anim.SetFloat("Speed", Mathf.Abs(vertical));
		}
		else
		{
			anim.SetFloat("Speed", 0);
		}
		myP.velocity = new Vector2(horizontal * speed, vertical * speed);
		if (horizontal > 0 && !facingRight)
		{
			Flip(horizontal);
		}

		else if (horizontal < 0 && facingRight)
		{
			Flip(horizontal);
		}
	}

	private void Flip(float horizontal)
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}