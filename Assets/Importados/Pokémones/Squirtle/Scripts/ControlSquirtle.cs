using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSquirtle : MonoBehaviour
{

    Rotacion rotar;
    DisparoSquirtle feedback;
    DisparoSquirtle disparo;
    VelocidadSquirtle motor;
    public float salud = 100;

    // Use this for initialization
    void Start()
    {

        rotar = GetComponent<Rotacion>();
        feedback = GetComponentInChildren<DisparoSquirtle>();
        disparo = GetComponent<DisparoSquirtle>();
        motor = GetComponent<VelocidadSquirtle>();

    }

    // Update is called once per frame
    void Update()
    {

        rotar.RotarTanque();
        feedback.Feedback();
        disparo.Disparo();
        motor.Motor();

    }

    public void Daño(float daño)
    {
        daño = 10;
        salud -= daño;
    }
}
