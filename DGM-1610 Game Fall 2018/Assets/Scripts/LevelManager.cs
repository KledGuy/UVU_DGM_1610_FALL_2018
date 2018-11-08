﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;
	public GameObject Player2;

	//Particles, man
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Delay
	public float RespawnDelay;

	//Penalty
	public int PointPenaltyOnDeath;

	//Gravity Value
	private float GravityStore;

	// Use this for initialization
	void Start () {
		//Player = FindObjectOfType<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer() {
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo() {
		//Death Particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//Hide Player
		//player.enabled = false;
		Player2.SetActive(false);
		Player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");	
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match Transformed position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//Show Player
		//Player.enabled = true;
		Player2.SetActive(true);
		Player.GetComponent<Renderer> ().enabled = true;
		//Spawn Player
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}
