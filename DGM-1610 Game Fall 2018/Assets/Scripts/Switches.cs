using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	public int Num;
	public string name;

	//Homework
	public int Pomello;
	public string Capitals;
	public int Pennies;

	// Use this for initialization
	void Start () {

		if(Num == 10){
			print("Ten outta ten");
		}
		else{
			print(Num + " outta ten");
		}

		switch(Num){
			
			//case 1:
				//print("You chose a " + Num);
			//break;

			//case 3:
				//print("You choo choo chose" + Num);
			//break;

			//case 6:
				//print("You chews a " + Num);
			//break;

			//case 10:
				//print("You choz a " + Num);
			//break;

			//default:
				//print("No comprende" + Num);
			//break;

		}


		switch(name){
			case "Teddi Krueger":
				print("Hello " + name + ", enjoy your stay");
			break;

			case "Jonathan":
				print("Here's " + name );
			break;

			case "Winky":
				print("Hello Chris Seavor /" + name );
			break;

			default:
				print("Who are you supposed to be, " + name + "?");
			break;
		}
		//Homework switches
		switch(Pomello){
			case 1:
				print("Ichi " + Pomello);
			break;

			case 3:
				print("Pomellos doubled =" + Pomello);
			break;

			case 5:
				print(" Pomellos x3 "+ Pomello);
			break;

			default:
				print("I don't recognize this");
			break;
		}
		switch(Capitals){
			case "Topeka":
				print("It's hot in " + Capitals);
			break;

			case "Boise":
				print("Idaho potatoes in " + Capitals);
			break;

			case "Denver":
				print("Radiated plateus in " + Capitals);
			break;

			default:
				print("I don't know about this:");
			break;
		}
		switch(Pennies){
			case 4:
				print("Only " + Pennies + "Pennies");
			break;

			case 8:
				print("Pennies are now: " + Pennies + " See?");
			break;

			case 12:
				print("Lots more pennies, see? " + Pennies);
			break;

			default:
				print("I don't recognize this amount");
			break;
		}


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
