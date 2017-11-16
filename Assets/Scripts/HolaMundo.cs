using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour {

	int numero = 0;
	// Use this for initialization
	void Start () {
		print ("Hola mundo");
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Has apretado enter!");
		}

		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			sumarNumero();
			print ("Abajo");
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			sumarNumero();
			print ("Arriba");
		}

		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			sumarNumero();
			print ("Derecha");
		}

		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			sumarNumero();
			print ("Izquierda");
		}


	}

	private void sumarNumero(){
		numero++;
		print ("Número actual: "+numero);
	}
}
