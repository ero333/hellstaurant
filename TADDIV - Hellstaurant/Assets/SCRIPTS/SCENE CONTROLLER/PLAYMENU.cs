using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;

public class PLAYMENU : MonoBehaviour
{

    public int hayPartida;

    public GameObject botonContinuar;

    public int ultimoNivel;

    public int nohaypartida = 0;

    public AudioSource buttonsound;



    private void Awake()
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        hayPartida = PlayerPrefs.GetInt("PartidaGuardada");
        
        ultimoNivel = PlayerPrefs.GetInt("UltimoNivelAlcanzado");
    }

    // Update is called once per frame
    void Update()
    {
        if (hayPartida == 1)
        {
            botonContinuar.SetActive(true);
        }
        if (hayPartida == 0)
        {
            botonContinuar.SetActive(false);
        }
    }

    public void jugar()
    {
        buttonsound.Play(); 

        SceneManager.LoadScene("Selector de Niv");

        PlayerPrefs.SetInt("PartidaGuardada", 1 );

        
    }

    public void Reset()
    {
        buttonsound.Play();

        PlayerPrefs.DeleteAll();

        botonContinuar.SetActive(false);

        PlayerPrefs.SetInt("PartidaGuardada", nohaypartida);

        SceneManager.LoadScene("Inicial Cutscene");

        


    }

    public void Tienda()
    {
        buttonsound.Play();

        SceneManager.LoadScene("Tienda");
    }

    public void creditos()
    {
        buttonsound.Play();

        SceneManager.LoadScene("Creditos");
    }

    public void continuar()
    {
        buttonsound.Play();

        SceneManager.LoadScene(ultimoNivel +1);
    }

    public void menuprincipal()
    {
        buttonsound.Play();

        SceneManager.LoadScene("Menu");
    }

    public void tiendaskins()
    {
        buttonsound.Play();

        SceneManager.LoadScene("Skins");
    }
}
