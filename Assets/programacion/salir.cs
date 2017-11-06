using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salir : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    public void CargaNivel1(string pNombreNivel1)
    {
        Application.Quit();
        Debug.Log("gracias");
    }
}
