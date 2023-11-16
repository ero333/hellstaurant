using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class muteSound : MonoBehaviour

{

    public bool sonidoMuteado = true; // Estado de sonido mutado
    public Sprite spriteMuteado;
    public Sprite spriteDesmuteado;


    public bool SFXMuteado = true; // Estado de sonido mutado

    public Sprite spriteSFXMuteado;
    public Sprite spriteSFXDesmuteado;

    public Button botonSonido;
    public AudioSource buttonsound;
    public GameObject BGMusic;

    public GameObject SFXSound;

    public GameObject musicGroup;

    public MusicAlternate musicAlternate;

    public Button SFXBoton;


    public void Awake()
    {


    }

    public void Start()
    {



        musicGroup = GameObject.FindGameObjectWithTag("musicamenu");

        SFXSound = GameObject.FindGameObjectWithTag("SFXSound");

        buttonsound = GameObject.FindGameObjectWithTag("sonidoboton").GetComponent<AudioSource>();

        sonidoMuteado = PlayerPrefs.GetInt("SonidoMuteado", 0) == 1;

        SFXMuteado = PlayerPrefs.GetInt("SFXMuteado", 0) == 1;

        //    // Cargar el estado de mute al inicio de la escena
        //    sonidoMuteado = PlayerPrefs.GetInt("SonidoMuteado", 0) == 1;


            ActualizarAudioListener();
            ActualizarSpriteBoton();

            ActualizarAudioListenerSFX();
            ActualizarSFXBoton(); 
    }

    public void AlternarMute()
    {
        //buttonsound.Play(); 
    //    // Cambia el estado de sonido mutado
     sonidoMuteado = !sonidoMuteado;

    //    // Guarda el estado de mute o unmute en PlayerPrefs
     PlayerPrefs.SetInt("SonidoMuteado", sonidoMuteado ? 1 : 0);
        //    PlayerPrefs.Save();

        ActualizarSpriteBoton();
        ActualizarAudioListener();

    }

    public void ActualizarAudioListener()
    {
         if (sonidoMuteado)
        {
            // Busca el objeto por su tag
            mantenerObjeto MantenerObjeto = FindObjectOfType<mantenerObjeto>();

            // Verifica si se encontró un objeto con el tag especificado
            if (MantenerObjeto != null)
            {
                // Activa el objeto
                musicGroup.SetActive(false);
            }
            else
            {
                Debug.LogWarning("No se encontró ningún objeto con el tag: " + MantenerObjeto);
            }


        }
        if (!sonidoMuteado)
        {
            // Busca el objeto por su tag
            mantenerObjeto MantenerObjeto = FindObjectOfType<mantenerObjeto>();

            // Verifica si se encontró un objeto con el tag especificado
            if (MantenerObjeto != null)
            {
                // Activa el objeto
                musicGroup.SetActive(true);
            }
            else
            {
                Debug.LogWarning("No se encontró ningún objeto con el tag: " + MantenerObjeto);
            }


        }
    }

    public void ActualizarSpriteBoton()
    {
        if (botonSonido != null)
        {
            Image imagenBoton = botonSonido.GetComponent<Image>();
            if (imagenBoton != null)
            {
                imagenBoton.sprite = sonidoMuteado ? spriteMuteado : spriteDesmuteado;
            }
        }

    }



    public void AlternarSFX()
    {
        //buttonsound.Play(); 
        //    // Cambia el estado de sonido mutado
        SFXMuteado = !SFXMuteado;

        //    // Guarda el estado de mute o unmute en PlayerPrefs
        PlayerPrefs.SetInt("SFXMuteado", SFXMuteado ? 1 : 0);
        //    PlayerPrefs.Save();

        ActualizarSFXBoton();
        ActualizarAudioListenerSFX();

    }

    public void ActualizarAudioListenerSFX()
    {
        if (SFXMuteado)
        {
            SFXSound.SetActive(false);
        }
        if (!SFXMuteado)
        {
            SFXSound.SetActive(true);
        }
    }

    public void ActualizarSFXBoton()
    {
        if ( SFXBoton != null)
        {
            Image imagenSFXboton = SFXBoton.GetComponent<Image>();
            if (imagenSFXboton != null)
            {
                imagenSFXboton.sprite = SFXMuteado ? spriteSFXMuteado : spriteSFXDesmuteado;
            }
        }

    }


}
