using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cutsceneFinal : MonoBehaviour
{
    public GameObject animacion1, animacion2, animacion3, animacion4;

    public GameObject botonSiguiente;

    public GameObject popupEndless;

    public GameObject botonPopup;

    public float contadorAnim;

    void Start()
    {
        contadorAnim = 0;
        animacion1.SetActive(true);


        EventSystem.current.SetSelectedGameObject(botonSiguiente.GetComponentInChildren<Button>().gameObject);
    }

    public void pasarAnim()
    {
        contadorAnim++;

        if (contadorAnim == 1)
        {
            animacion1.SetActive(false);
            animacion2.SetActive(true);
        }

        if (contadorAnim == 2)
        {
            animacion2.SetActive(false);
            animacion3.SetActive(true);
        }

        if (contadorAnim == 3)
        {
            animacion3.SetActive(false);
            animacion4.SetActive(true);
        }

        if (contadorAnim == 4)
        {
            botonSiguiente.SetActive(false);
            popupEndless.SetActive(true);


            EventSystem.current.SetSelectedGameObject(botonPopup.GetComponentInChildren<Button>().gameObject);
        }

    }


    public void desactivarBoton()
    {
        botonSiguiente.SetActive(false);

    }

    public void activarBoton()
    {
        botonSiguiente.SetActive(true);

    }


}
