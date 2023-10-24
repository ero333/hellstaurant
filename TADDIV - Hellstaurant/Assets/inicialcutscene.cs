using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inicialcutscene : MonoBehaviour
{
    public GameObject animacion1, animacion2, animacion3;

    public GameObject botonSiguiente;

    public float contadorAnim;

    void Start()
    {
        contadorAnim = 0;
        animacion1.SetActive(true);
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
            SceneManager.LoadScene("Nivel 0 (tutorial)");
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
