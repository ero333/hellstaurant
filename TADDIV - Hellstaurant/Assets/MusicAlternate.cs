using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicAlternate : MonoBehaviour
{

    public MusicAlternate instancia;

    public GameObject musicaMenu;

    private void Awake()
    {
        // Verifica si ya existe una instancia de ControlDeMusica
        if (instancia != null && instancia != this)
        {
            // Destruye este objeto si ya hay una instancia
            Destroy(gameObject);
            return;
        }

        // Marca este objeto como persistente entre escenas
        DontDestroyOnLoad(gameObject);

        // Asigna esta instancia como la única instancia
        instancia = this;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex <= 18)

        {
            musicaMenu.SetActive(false);
        }

        if (SceneManager.GetActiveScene().buildIndex >= 19 && SceneManager.GetActiveScene().buildIndex <= 22)

        {
            musicaMenu.SetActive(false);
        }


        else
        {
            musicaMenu.SetActive(true);
        }

    }

}
