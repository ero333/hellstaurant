using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYMENU : MonoBehaviour
{

    public int hayPartida;

    public GameObject botonContinuar;

    public int ultimoNivel;

    public int nohaypartida = 0;

    // Start is called before the first frame update
    void Start()
    {
        hayPartida = PlayerPrefs.GetInt("PartidaGuardada");
        
        ultimoNivel = PlayerPrefs.GetInt("NivelActual:" + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (hayPartida == 1)
        {
            botonContinuar.SetActive(true);
        }
    }

    public void jugar()
    {
        SceneManager.LoadScene("Selector de Niv");

        PlayerPrefs.SetInt("PartidaGuardada", 1 );

        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("PartidaGuardada", nohaypartida);

        
    }

    public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }

    public void creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void continuar()
    {
        SceneManager.LoadScene(ultimoNivel);
    }

}
