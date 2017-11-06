using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoGengar : MonoBehaviour
{

    public GameObject colisionador;
    public string coliNombre;
    public StatsGengar pS;
    public float danoACausar;

    // Use this for initialization
    void Start()
    {
        pS = GetComponent<StatsGengar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {

        colisionador = collision.gameObject;
        coliNombre = colisionador.name;


        if (colisionador.tag == "MisilJugador")
        {
            Debug.Log("Me DIO");
            switch (coliNombre)
            {
                case "misilCharmander(Clone)":

                    danoACausar = (colisionador.GetComponent<FuerzaCharmander>().porcentaje) / 10;
                    break;

                case "misilSquirtle(Clone)":

                    danoACausar = (colisionador.GetComponent<FuerzaSquirtle>().porcentaje) / 10;
                    break;
            }
            pS.puntosSalud -= pS.puntosSaludMax * danoACausar;
        }
    }
}
