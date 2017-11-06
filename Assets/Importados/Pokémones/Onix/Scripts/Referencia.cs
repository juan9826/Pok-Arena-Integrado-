using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referencia : MonoBehaviour {

    Transform jugador;

	// Use this for initialization
	void Start () {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(jugador);
	}
}
