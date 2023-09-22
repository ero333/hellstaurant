using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene : MonoBehaviour
{
    public GameObject animacion1, animacion2, animacion3, animacion4, animacion5, animacion6, animacion7, animacion8, animacion9, animacion10, animacion11, animacion12, animacion13, animacion14, animacion15;
    
    public GameObject botonSiguiente;

    public float contadorAnim;

    void Start()
    {
        contadorAnim = 0;
        animacion1.SetActive(true);
    }

    public void pasarAnim()
    {
        contadorAnim ++;

        if(contadorAnim == 1)
        {
            animacion1.SetActive(false);
            animacion2.SetActive(true);
        }

            if(contadorAnim == 2)
        {
            animacion2.SetActive(false);
            animacion3.SetActive(true);
        }

            if(contadorAnim == 3)
        {
            animacion3.SetActive(false);
            animacion4.SetActive(true);
        }

            if(contadorAnim == 4)
        {
            animacion4.SetActive(false);
            animacion5.SetActive(true);
        }

            if(contadorAnim == 5)
        {
            animacion5.SetActive(false);
            animacion6.SetActive(true);
        }

            if(contadorAnim == 6)
        {
            animacion6.SetActive(false);
            animacion7.SetActive(true);
        }

            if(contadorAnim == 7)
        {
            animacion7.SetActive(false);
            animacion8.SetActive(true);
        }

            if(contadorAnim == 8)
        {
            animacion8.SetActive(false);
            animacion9.SetActive(true);
        }

            if(contadorAnim == 9)
        {
            animacion9.SetActive(false);
            animacion10.SetActive(true);
        }

            if(contadorAnim == 10)
        {
            animacion10.SetActive(false);
            animacion11.SetActive(true);
        }

            if(contadorAnim == 11)
        {
            animacion11.SetActive(false);
            animacion12.SetActive(true);
        }

            if(contadorAnim == 12)
        {
            animacion12.SetActive(false);
            animacion13.SetActive(true);
        }

            if(contadorAnim == 13)
        {
            animacion13.SetActive(false);
            animacion14.SetActive(true);
        }

            if(contadorAnim == 14)
        {
            animacion14.SetActive(false);
            animacion15.SetActive(true);
        }

            if(contadorAnim == 15)
        {
            animacion15.SetActive(false);
        }


    }


}
