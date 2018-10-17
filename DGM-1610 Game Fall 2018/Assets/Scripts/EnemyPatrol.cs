﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

	//Variables
	public float MoveSpeed;
	public bool MoveRight;

	//Wall Check
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;

	//Edge Check
	private bool NotAtEdge;
	public Transform EdgeCheck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);

		//Turn around at Wall or Edge
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}
		
		if (MoveRight){
			transform.localScale = new Vector3(-0.2f,0.2f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else{
			transform.localScale = new Vector3(0.2f,0.2f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
}