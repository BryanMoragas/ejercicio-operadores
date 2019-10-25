using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioOperadores : MonoBehaviour {

	public int numeroUno = 1;	
	public int numeroDos = 2;
	public int numeroTres;
	public float numeroCuatro = 4;
	public float numeroCinco;

	// Use this for initialization
	void Start () {

		Debug.Log (numeroUno + numeroTres + numeroCuatro);
		Debug.Log (numeroUno - numeroDos - numeroCinco);
		Debug.Log ((numeroUno + numeroDos) * numeroCinco);
		Debug.Log ((numeroUno - numeroTres) / (numeroCinco + numeroCuatro));
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
