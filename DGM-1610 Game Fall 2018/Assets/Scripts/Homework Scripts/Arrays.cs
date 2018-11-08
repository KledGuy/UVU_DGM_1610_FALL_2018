using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {


	public int[] Eggscellent = new int[11];

	public string[] Cheese;

	public string[] Coins;

	public int[] Puzzles = new int[4];

	public string[] Poodles;

	public int[] Handedness = new int[4];



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

		Cheese = new string[3];

		Cheese[0] = "Gouda";
		Cheese[1] = "Wensleydale";
		Cheese[2] = "Parmesan";
		Cheese[3] = "Blue";

		foreach(string item in Cheese){
			print ("Chese type " + item);
		}

		Coins = new string[5];

		Coins[0] = "Pennies";
		Coins[1] = "Nickles";
		Coins[2] = "Dimes";
		Coins[3] = "Quarters";
		Coins[4] = "Half Dollar";
		Coins[5] = "Dollar";

		Puzzles[0] = 5;
		Puzzles[1] = 4;
		Puzzles[2] = 3;
		Puzzles[3] = 2;
		Puzzles[4] = 1;

		Poodles[0] = "Type 1";
		Poodles[1] = "Type 2";
		Poodles[2] = "Type 3";
		Poodles[3] = "Type 4";
		Poodles[4] = "Type 5";

		foreach(string item in Poodles){
			print("Poodles of " + item);
		}


		Handedness[0] = 1;
		Handedness[1] = 2;
		Handedness[2] = 1;
		Handedness[3] = 1;
		Handedness[4] = 3;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
