using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaCharmander : MonoBehaviour {

    StatsCharmander resistencia;
    VelocidadCharmander trigger;
    public int segundero = 1;
    public int segundero2 = 1;
    public float deltaTime = 0;
    public float staminaMax;

	// Use this for initialization
	void Start () {
        trigger = GetComponent<VelocidadCharmander>();
        resistencia = GetComponent<StatsCharmander>();
        staminaMax = resistencia.staminaMax;
	}
	
	// Update is called once per frame
	void Update () {
        if (trigger.BuffOn)
        {
         if(trigger.BuffTime >= segundero)
            {
                segundero += 1;
                resistencia.stamina -= resistencia.staminaMax * 0.1f;
            }
        }
        else
        {
            segundero = 1;
            deltaTime += Time.deltaTime;
            if(deltaTime >= segundero2)
            {
                segundero2 += 1;

                if(resistencia.stamina < resistencia.staminaMax)
                {
                    resistencia.stamina += resistencia.staminaMax * 0.02f;
                }
            }
        }
    }
}
