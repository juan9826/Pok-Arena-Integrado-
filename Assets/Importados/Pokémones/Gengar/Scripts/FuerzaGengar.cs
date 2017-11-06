using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaGengar : MonoBehaviour
{

    Rigidbody mRigidbody;
    Transform mTransform;
    GameObject enemigo;
    public float danoAtaque;
    public float potHabilidad;
    public float desgStamina;
    public float porcentaje;
    public float magnitud;

    // Use this for initialization
    void Start()
    {
        enemigo = GameObject.FindGameObjectWithTag("Enemy");
        mTransform = GetComponent<Transform>();
        danoAtaque = (enemigo.GetComponent<StatsGengar>().ataque) / 100;
        potHabilidad = 0.5f;
        float stamMax = enemigo.GetComponent<StatsGengar>().staminaMax;
        float stamGastada = enemigo.GetComponent<StatsGengar>().staminaMax - enemigo.GetComponent<StatsGengar>().stamina;
        desgStamina = ((100) / (stamMax / stamGastada)) / (100);
        porcentaje = (danoAtaque + potHabilidad - desgStamina);
        magnitud = porcentaje * (1000);
        mRigidbody = GetComponent<Rigidbody>();
        Vector3 fuerza = mTransform.forward * magnitud;
        mRigidbody.AddForce(fuerza);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
