using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarFunc : MonoBehaviour {

	//Variables
	public int Vari1 = 2;
	private int Vari2 = 5;
	private bool Vari3 = true;
	public int Vari4 = 1;
	public int Vari5 = 1;
	public int Vari6 = 1;

	//Functions
	void VariMultiply () {
		Vari4 = (Vari1 * Vari2);
	}

	void VariDivide () {
		Vari5 = (Vari1 / Vari2);
	}

	void VariExponent () {
		Vari6 = (Vari1 ^ Vari2);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
