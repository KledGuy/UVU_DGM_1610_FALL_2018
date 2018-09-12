using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// Player Movement Variables
	public int MoveSpeed;
	private float JumpHeight;

	//Player grounded variables
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		Grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheck)
	}

	// Update is called once per frame
	void Update () {

		//This code makes it jump
		if(Input.GetKeyDown (KeyCode.Space)&& grounded){
			Jump();
		}

		//This code makes it move from side to side
		if(Input.GetKey (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().
		}
		if(Input.GetKey (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, Grounded)
	}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
