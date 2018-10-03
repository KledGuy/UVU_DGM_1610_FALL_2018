using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour {

	//Variables
	public int Var1;
	public int Var2;
	int total;

	//Addition Function
	public int func(int Var1,int Var2) {
		total = Var1 + Var2;
		print(total);
		return total;
	}
	
	// Use this for initialization
	void Start () {
		func(1,3);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
