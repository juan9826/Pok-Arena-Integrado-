using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoSquirtle : MonoBehaviour {

    public GameObject colisionador;
    public string coliNombre;
    public StatsSquirtle pS;
    public float danoACausar;

    // Use this for initialization
    void Start () {
        pS = GetComponent<StatsSquirtle>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        
        colisionador = collision.gameObject;
        coliNombre = colisionador.name;
        

        if (colisionador.tag == "MisilEnemigo")
        {
            Debug.Log("Me DIO");
            switch (coliNombre)
            {
                case "misilOnix(Clone)":

                    danoACausar = (colisionador.GetComponent<FuerzaOnix>().porcentaje) / 10;
                    break;

                case "misilGengar(Clone)":

                    danoACausar = (colisionador.GetComponent<FuerzaGengar>().porcentaje) / 10;
                    break;
            }
            pS.puntosSalud -= pS.puntosSalud * danoACausar;
        }
    }
}
