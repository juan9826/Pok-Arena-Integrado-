using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadSquirtle : MonoBehaviour
{
    Transform mTransform;
    public float magnitud;
    private AudioSource sonido;
    public float BuffTime = 0;
    public bool BuffOn;
    public float stamRestante;


    // Use this for initialization
    void Start()
    {
        magnitud = GetComponent<StatsSquirtle>().velocidad;
        mTransform = GetComponent<Transform>();
        sonido = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Motor()
    {
        Vector3 direccionX = new Vector3(1, 0, 0);
        float sentidoX = Input.GetAxis("Horizontal");
        Vector3 velocidadX = direccionX * magnitud * sentidoX;





        // z
        Vector3 direccionZ = mTransform.forward;
        float sentidoZ = Input.GetAxis("Vertical");
        Vector3 velocidadZ = direccionZ * magnitud * sentidoZ;
        Vector3 velocidad = velocidadX + velocidadZ;//+ velocidadY + velocidadZ;
        Vector3 desplazamiento = velocidad * Time.deltaTime;

        // pisicion nueva = posicion actual + desplazamiento
        Vector3 posicionInicial = mTransform.position;
        Vector3 posicionNueva = mTransform.position + desplazamiento;

        // actualices la posicion
        mTransform.position = posicionNueva;

        // audio
        if ((sentidoZ < 0) || (sentidoZ > 0) || (sentidoX < 0) || (sentidoX > 0))
        {
            sonido.mute = false;
        }
        else
        {
            sonido.mute = true;
        }

        stamRestante = GetComponent<StatsSquirtle>().stamina;

        
        if(stamRestante > 0)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                BuffOn = true;
                magnitud = 90;
            }
            else
            {
                BuffOn = false;
                BuffTime = 0;
                magnitud = 30;
            }

            if (BuffOn)
            {
                BuffTime += Time.deltaTime;

            }
        }
        else
        {
            BuffOn = false;
            BuffTime = 0;
            magnitud = 30;
        }

    }

}