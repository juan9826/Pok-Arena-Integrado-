using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharmander : MonoBehaviour
{

    Rotacion rotar;
    DisparoCharmander feedback;
    DisparoCharmander disparo;
    VelocidadCharmander motor;
    public float salud = 100;

    // Use this for initialization
    void Start()
    {

        rotar = GetComponent<Rotacion>();
        feedback = GetComponentInChildren<DisparoCharmander>();
        disparo = GetComponent<DisparoCharmander>();
        motor = GetComponent<VelocidadCharmander>();

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
