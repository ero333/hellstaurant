using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.Analytics;
using Unity.Services.Analytics;

public class TriviaMenu : MonoBehaviour
{

    public GameObject pantallatrivia;
    public GameObject correcto;
    public GameObject incorrecto;
    public int respuestaCorrecta;
    public int respuestaElegida;

    public int monedasGanadas;

    public int contadorMonedas;

    // Start is called before the first frame update
    void Start()
    {
        contadorMonedas = PlayerPrefs.GetInt("MonedasRecolectadas:");
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void respuesta1()
    {
        respuestaElegida = 1;

        if (respuestaElegida == respuestaCorrecta)
        {


            PlayerPrefs.SetInt("MonedasRecolectadas:", contadorMonedas + monedasGanadas);
            Debug.Log("Correcto!");
            pantallatrivia.gameObject.SetActive(false);
            incorrecto.gameObject.SetActive(false);
            correcto.gameObject.SetActive(true);


        }
        else
        {
            pantallatrivia.gameObject.SetActive(false);
            Debug.Log("Incorrecto!");
            correcto.gameObject.SetActive(false);
            incorrecto.gameObject.SetActive(true);
        }
    }

    public void respuesta2()
    {
        respuestaElegida = 2;

        if (respuestaElegida == respuestaCorrecta)
        {


            PlayerPrefs.SetInt("MonedasRecolectadas:", contadorMonedas + monedasGanadas);
            Debug.Log("Correcto!");
            pantallatrivia.gameObject.SetActive(false);
            incorrecto.gameObject.SetActive(false);
            correcto.gameObject.SetActive(true);


        }
        else
        {
            pantallatrivia.gameObject.SetActive(false);
            Debug.Log("Incorrecto!");
            correcto.gameObject.SetActive(false);
            incorrecto.gameObject.SetActive(true);
        }
    }

}
