using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoCharmander : MonoBehaviour
{

    Transform localPos;
    Rigidbody dashPos;
    Rigidbody misilPos;
    public float magDisparo = 1200f;
    public float magnitud = 50f;
    public GameObject misil;
    Transform posReferencia;
    public Quaternion rotReferencia;
    Transform rotRef;

    // Use this for initialization
    void Start()
    {

        localPos = GetComponent<Transform>();
        dashPos = GetComponent<Rigidbody>();
        posReferencia = GameObject.Find("Referencia").GetComponent<Transform>();
        rotRef = GameObject.Find("cam1").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Disparo()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rotReferencia = Quaternion.Euler(rotRef.eulerAngles);
            Instantiate(misil, posReferencia.position, rotReferencia);

        }
    }

    public void Feedback()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 direccion = localPos.forward;
            float sentido = -1;
            Vector3 fuerza = magnitud * direccion * sentido;
            dashPos.AddForce(fuerza);
        }

    }
}
