using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class ControladorMusica : MonoBehaviour
{
    public AudioSource musica;

    private bool musicaSilenciada;


private void Start()
{

        // Asegúrate de que el componente AudioSource de la música esté asignado en el Inspector.
        if (musica != null)
    {
        musica = GetComponent<AudioSource>();
    }
}

public void AlternarMusica()
{
    musicaSilenciada = !musicaSilenciada;

    if (musicaSilenciada)
    {
        musica.Pause();
    }
    else
    {
        musica.UnPause();
    }
  }
}


