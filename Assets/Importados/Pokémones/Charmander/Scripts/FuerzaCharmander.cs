using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaCharmander : MonoBehaviour
{

    Rigidbody mRigidbody;
    Transform mTransform;
    GameObject jugador;
    public float danoAtaque;
    public float potHabilidad;
    public float desgStamina;
    public float porcentaje;
    public float magnitud = 100;

    // Use this for initialization
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
        danoAtaque = (jugador.GetComponent<StatsCharmander>().ataque)/100;
        potHabilidad = 0.5f;
        float stamMax = jugador.GetComponent<StatsCharmander>().staminaMax;
        float stamGastada = jugador.GetComponent<StatsCharmander>().staminaMax - jugador.GetComponent<StatsCharmander>().stamina;
        desgStamina = ((100) / (stamMax / stamGastada)) / (100);
        porcentaje = (danoAtaque + potHabilidad - desgStamina);
        magnitud = porcentaje*(1000);
        mRigidbody = GetComponent<Rigidbody>();
        mTransform = GetComponent<Transform>();
        Vector3 fuerza = mTransform.forward * magnitud;
        mRigidbody.AddForce(fuerza);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
