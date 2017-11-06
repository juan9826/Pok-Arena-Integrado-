using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCamara : MonoBehaviour {

    // Creamos las variables de las cámaras

    Camera cam1;
    Camera cam2;

//Luego asignalas en el inspector, arrastra las respectivas cámaras
    


    // Use this for initialization
    void Start () {

        cam1 = GameObject.Find("cam1").GetComponent<Camera>();
        cam2 = GameObject.Find("cam2").GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        //Al pulsar 1 las camaras 2 y 3 se desactivan
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            
        }
    }

}
