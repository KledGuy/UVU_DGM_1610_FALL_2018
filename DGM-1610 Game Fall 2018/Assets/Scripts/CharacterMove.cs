using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool DoubleJump;

	//Player grounded variables
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	private bool Grounded;

	//Non-Stick Player
	private float moveVelocity;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}

	// Update is called once per frame
	void Update () {

		//This code makes it jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		if(Grounded)
			DoubleJump = false;

		if(Input.GetKeyDown (KeyCode.Space)&& !Grounded && !DoubleJump){
			Jump();
			DoubleJump = true;
		}

		//Non-Stick Player
		moveVelocity= 0f;

		//This code makes it move from side to side
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = MoveSpeed;
		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
			moveVelocity = -MoveSpeed;
		
		//Flipping
		if(GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(1f,1f,1f);

		else if(GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-1f,1f,1f);

		}
	}
	
	//Jumping code
	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
