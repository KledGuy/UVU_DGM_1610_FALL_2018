using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrutiLupis : MonoBehaviour {
	public int Numero = 40;

	public string Color = "Blue";

	public string Pennies = "Twenty";

	// Use this for initialization
	void Start () {

		for(int i=0; i <= 100; i++){

			print(i + " Ants Marching");


		}

		while(Numero >= 0){
			print("Countdown " + Numero);
			Numero --;

		}

		for(int i=20; i >= 00; i--){

			print(i + " Numbers");

		}

		while(Color == "Red"){
			print("Color equals " + Color);
			

		}

		for(int i=37; i >= 00; i--){

			print("Totals = " + i);

		}

		while(Pennies == "Twenty"){
			print("Take a penny ");
			Pennies = "Nineteen";
			

		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
