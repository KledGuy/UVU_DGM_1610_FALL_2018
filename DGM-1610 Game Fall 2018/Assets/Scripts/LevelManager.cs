using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Controller2D Player;

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
		player = FindObjectOfType<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void RespawnPlayer() {
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo() {
		//Death Particle
		Instantiate (deathParticle. player.transform.position, player.transform.rotation;);
		//Hide Player
		player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		//Gravity Reset
		gravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
		player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//Point Penalty
		ScoreManager.AddPoints(-pointPenaltyOnDeath);
		//Debug Message
		Debug.Log ("Player Respawn");		
	}
}
