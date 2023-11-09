using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicAlternate : MonoBehaviour
{

    public MusicAlternate instancia;

    public GameObject musicaMenu;

    public AudioSource musicaMenues;

    public AudioSource musicaNiveles;

    private void Awake()
    {
        // Verifica si ya existe una instancia de ControlDeMusica
        if (instancia != null && instancia != this)
        {
            // Destruye este objeto si ya hay una instancia
            Destroy(this.gameObject);
            return;
        }

        // Marca este objeto como persistente entre escenas
        DontDestroyOnLoad(gameObject);

        // Asigna esta instancia como la única instancia
        instancia = this;
    }

    public void Start()
    {

        musicaMenues = GameObject.FindGameObjectWithTag ("musicafondo").GetComponent<AudioSource>();

        musicaNiveles = GameObject.FindGameObjectWithTag("musicabatalla").GetComponent<AudioSource>();



        if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex <= 18)

        {
            musicaMenues.volume = 0.0f;
            musicaNiveles.volume = 1.0f;
        }

        if (SceneManager.GetActiveScene().buildIndex >= 19 && SceneManager.GetActiveScene().buildIndex <= 22)

        {
            musicaMenues.volume = 0.0f;
            musicaNiveles.volume = 1.0f;
        }


        else
        {
            musicaMenues.volume = 1.0f;
            musicaNiveles.volume = 0.0f;
        }
    }

    void Update()
    {


    }

}
