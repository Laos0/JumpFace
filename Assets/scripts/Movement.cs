using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public Rigidbody2D rb;
	public Transform groundCheck, groundCheck1, groundCheck2, groundCheck3;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround, onGround1, onGround2, onGround3;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (3, rb.velocity.y);

		// if empty gameObject touches layer called ground, then it becomes true, 
		// Empty Ground Object must touch the layer ground inorder for Face to Jump again
		onGround = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
		onGround1 = Physics2D.OverlapCircle (groundCheck1.position, groundCheckRadius, whatIsGround);
		onGround2 = Physics2D.OverlapCircle (groundCheck2.position, groundCheckRadius, whatIsGround);
		onGround3 = Physics2D.OverlapCircle (groundCheck3.position, groundCheckRadius, whatIsGround);


		if(Input.GetKeyDown("space") && onGround || Input.GetKeyDown("space") && onGround1 || Input.GetKeyDown("space") && onGround2 || Input.GetKeyDown("space") && onGround3){
			rb.velocity = new Vector2 (rb.velocity.x, 5);
		}



	}
}
