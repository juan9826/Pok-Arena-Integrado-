using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAGengar : MonoBehaviour
{

    //Follow:
    public float minDist = 40;
    public GameObject jugador;
    Transform transformJugador;
    Transform mTransform;
    Vector3 posJugador;
    Vector3 mPosicion;
    public float velocidad;

    //Decidir:
    public float deltaTime = 0;
    public int segundero = 1;

    //Golpear:
    StatsGengar golpe;

    // Use this for initialization
    void Start()
    {
        velocidad = GetComponent<StatsGengar>().velocidad;
        mTransform = GetComponent<Transform>();
        jugador = GameObject.FindGameObjectWithTag("Player");
        transformJugador = jugador.transform;
        golpe = GetComponent<StatsGengar>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mirarA = new Vector3(transformJugador.position.x, transform.position.y, transformJugador.position.z);
        transform.LookAt(mirarA);

        deltaTime += Time.deltaTime;
        if (deltaTime >= segundero)
        {
            segundero += 1;

            int random = Random.Range(0, 2);

            if (random == 0)
            {
                Follow();
            }
            else
            {
                Disparar();
            }

        }
    }

    public void Follow()
    {
        posJugador = transformJugador.position;
        mPosicion = mTransform.position;
        float distancia = Vector3.Distance(mPosicion, posJugador);

        if (distancia > minDist)
        {
            mTransform.position += (transform.forward * velocidad);
        }
        else
        {
            Golpear();
        }
    }

    //Disparar:
    public GameObject misil;
    Transform posReferencia;
    public Quaternion rotReferencia;

    public void Disparar()
    {

        posReferencia = GameObject.Find("RefEnem").GetComponent<Transform>();

        rotReferencia = Quaternion.Euler(posReferencia.eulerAngles);
        Instantiate(misil, posReferencia.position, rotReferencia);
    }

    public void Golpear()
    {

        switch (jugador.name)
        {
            case "Charmander":
                StatsCharmander pS;
                pS = jugador.GetComponent<StatsCharmander>();
                pS.puntosSalud -= (golpe.ataque / 100) * pS.puntosSaludMax;
                break;

            case "Squirtle":
                StatsSquirtle pS2;
                pS2 = jugador.GetComponent<StatsSquirtle>();
                pS2.puntosSalud -= (golpe.ataque / 100) * pS2.puntosSaludMax;
                break;
        }
    }
}