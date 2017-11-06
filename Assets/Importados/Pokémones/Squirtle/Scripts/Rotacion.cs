using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    Transform mTransform;
    Transform transformCam1;
    Transform transformCam2;
    public float magnitud2 = 50f;
    public bool TurretRot = false;


    // Use this for initialization
    void Start()
    {
        
        mTransform = GetComponent<Transform>();
        transformCam1 = GameObject.Find("cam1").GetComponent<Transform>();
        transformCam2 = GameObject.Find("cam2").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RotarTanque()
    {
        // X
        Vector3 rotacionX = new Vector3(0, 1, 0);
        float SentidoX = Input.GetAxis("Mouse X");
        Vector3 velocidadAngularX = rotacionX * magnitud2 * SentidoX;
        Vector3 desplazamientoX = velocidadAngularX * Time.deltaTime;
        Vector3 rotacionNuevaX = mTransform.eulerAngles + desplazamientoX;
        mTransform.eulerAngles = rotacionNuevaX;

        //Y
        Vector3 rotacionY = new Vector3(1, 0, 0);
        float SentidoY = Input.GetAxis("Mouse Y");
        Vector3 velocidadAngularY = rotacionY * magnitud2 * SentidoY;
        Vector3 desplazamientoY = velocidadAngularY * Time.deltaTime;
        Vector3 rotacionNuevaY = transformCam1.eulerAngles + desplazamientoY;
        transformCam1.eulerAngles = rotacionNuevaY;
        transformCam2.eulerAngles = rotacionNuevaY;

    }
}
