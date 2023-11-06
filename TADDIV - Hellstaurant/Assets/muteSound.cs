using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class muteSound : MonoBehaviour

{

    public bool sonidoMuteado = true; // Estado de sonido mutado
    public Sprite spriteMuteado;
    public Sprite spriteDesmuteado;
    public Button botonSonido;
    public AudioSource buttonsound;
    public GameObject BGMusic;



    private void Start()
    {
        buttonsound = GetComponent<AudioSource>();

        sonidoMuteado = PlayerPrefs.GetInt("SonidoMuteado", 0) == 1;


        BGMusic = GameObject.FindGameObjectWithTag("musicamenu");

        //    // Cargar el estado de mute al inicio de la escena
        //    sonidoMuteado = PlayerPrefs.GetInt("SonidoMuteado", 0) == 1;
            ActualizarAudioListener();
            ActualizarSpriteBoton();
    }

    public void AlternarMute()
    {
        //buttonsound.Play(); 
    //    // Cambia el estado de sonido mutado
     sonidoMuteado = !sonidoMuteado;

    //    // Guarda el estado de mute o unmute en PlayerPrefs
     PlayerPrefs.SetInt("SonidoMuteado", sonidoMuteado ? 1 : 0);
        //    PlayerPrefs.Save();

        ActualizarAudioListener();
        ActualizarSpriteBoton();
    }

    private void ActualizarAudioListener()
    {
         if (sonidoMuteado)
        {
            BGMusic.SetActive(false);
        }
        if (!sonidoMuteado)
        {
            BGMusic.SetActive(true);
        }
    }

    private void ActualizarSpriteBoton()
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


}
