using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteSound : MonoBehaviour
{

    private bool sonidoMuteado = true; // Estado de sonido mutado

    private void Start()
    {
        // Cargar el estado de mute al inicio de la escena
        sonidoMuteado = PlayerPrefs.GetInt("SonidoMuteado", 0) == 1;
        ActualizarAudioListener();
    }

    public void AlternarMute()
    {
        // Cambia el estado de sonido mutado
        sonidoMuteado = !sonidoMuteado;

        // Guarda el estado de mute o unmute en PlayerPrefs
        PlayerPrefs.SetInt("SonidoMuteado", sonidoMuteado ? 1 : 0);
        PlayerPrefs.Save();

        ActualizarAudioListener();
    }

    private void ActualizarAudioListener()
    {
        // Encuentra el componente AudioListener en la escena
        AudioListener audioListener = FindObjectOfType<AudioListener>();

        if (audioListener != null)
        {
            // Muta o desmuta el AudioListener según el estado
            audioListener.enabled = !sonidoMuteado;
        }
    }

}
