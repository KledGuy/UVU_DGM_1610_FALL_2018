using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {


	public int[] Eggscellent = new int[11];

	public string[] Cheese;



	// Use this for initialization
	void Start () {

		Eggscellent[0] = 1;
		Eggscellent[1] = 2;
		Eggscellent[2] = 3;
		Eggscellent[3] = 4;
		Eggscellent[4] = 5;
		Eggscellent[5] = 6;
		Eggscellent[6] = 7;
		Eggscellent[7] = 8;
		Eggscellent[8] = 9;
		Eggscellent[9] = 10;
		Eggscellent[10] = 11;
		Eggscellent[11] = 12;

		print(Eggscellent[8]);

		Cheese = new string[4];

		Cheese[0] = "Gouda";
		Cheese[1] = "Wensleydale";
		Cheese[2] = "Parmesan";
		Cheese[3] = "Blue";

		foreach(string item in Cheese){
			print ("Chese type " + item);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
