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

    public GameObject levelmusic;

    public GameObject menumusic;

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

        levelmusic = GameObject.FindGameObjectWithTag("musicanivel");

        menumusic = GameObject.FindGameObjectWithTag("musicafondo");


        //musicaMenues = GameObject.FindGameObjectWithTag ("musicafondo").GetComponent<AudioSource>();

        //musicaNiveles = GameObject.FindGameObjectWithTag("musicabatalla").GetComponent<AudioSource>();




    }

    public void Update()
    {

        if (SceneManager.GetActiveScene().buildIndex >= 5 && SceneManager.GetActiveScene().buildIndex <= 18)

        {

            levelmusic.SetActive(true);
            menumusic.SetActive(false);

            //musicaMenues.volume = 0.0f;
            //musicaNiveles.volume = 1.0f;
        }

        if (SceneManager.GetActiveScene().buildIndex >= 19 && SceneManager.GetActiveScene().buildIndex <= 22)

        {

            levelmusic.SetActive(true);
            menumusic.SetActive(false);

            //musicaMenues.volume = 0.0f;
            //musicaNiveles.volume = 1.0f;
        }


        else
        {

            levelmusic.SetActive(false);
            menumusic.SetActive(true);
            //musicaMenues.volume = 0.0f;
            //musicaNiveles.volume = 0.0f;
        }

    }

}
