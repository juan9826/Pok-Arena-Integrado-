﻿using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class StatsOnix : MonoBehaviour
{
    //ONIX:

    public float puntosSalud = 50;
    public float puntosSaludMax = 50;
    public float ataque = 30;
    public float defensa = 30;
    public float mana = 60;
    public float stamina = 40;
    public float staminaMax = 40;
    public float velocidad = 3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (puntosSalud <= 0f)
        {
            SceneManager.LoadScene("2PJ");
        }
    }
}
