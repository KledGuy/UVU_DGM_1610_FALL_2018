using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour {

	enum Inventory {chinese, italian, thai, jamaican, mexican, egyptian, english, korean}


	// Use this for initialization
	void Start () {

		print(Inventory.chinese);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
