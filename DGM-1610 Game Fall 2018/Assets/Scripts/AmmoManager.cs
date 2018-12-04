using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoManager : MonoBehaviour {
	public static int Ammo;

	Text AmmoText;

	// Use this for initialization
	void Start () {
		AmmoText = GetComponent<Text>();

		Ammo = 5;	
	}

	// Update is called once per frame
	void Update () {
		if (Ammo < 0)
			Ammo = 0;
		AmmoText.text = "Out of Ammo";
		
	}
		
	public static void LoseAmmo (int AmmoToLose) {
		Ammo -= AmmoToLose;
	}		
}
