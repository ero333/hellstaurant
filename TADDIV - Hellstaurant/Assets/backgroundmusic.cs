using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backgroundmusic : MonoBehaviour
{
    private static backgroundmusic instancia;

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

        // Asigna esta instancia como la �nica instancia
        instancia = this;
    }

    // L�gica para reproducir, pausar, detener la m�sica, etc.
    // Puedes usar un componente AudioSource para reproducir la m�sica.



}
