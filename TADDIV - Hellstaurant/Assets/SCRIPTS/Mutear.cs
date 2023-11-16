using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mutear : MonoBehaviour
{
    bool Muteado;

    public Sprite spriteMuteado;
    public Sprite spriteDesmuteado;


    public Button botonMusica;


    public static Mutear instance;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        botonMusica = GameObject.FindGameObjectWithTag ("botonMusica").GetComponent<Button> ();


        Muteado = PlayerPrefs.GetInt("MUTEADO") == 1;


        MuteDesmute();

        

    }

    void Update()
    {
        if (Input.GetKeyDown("m"))

        {
            Mutearr();
        }


        if (PlayerPrefs.GetInt("MUTEADO") == 1)
        {
            
            if (botonMusica != null)
            {
                Image imagenBoton = botonMusica.GetComponent<Image>();

                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteMuteado;
                }

            }


        }

        else
        {
            if (botonMusica != null)
            {
                Image imagenBoton = botonMusica.GetComponent<Image>();
                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteDesmuteado;
                }

            }

        }

    }





    public void Mutearr()
    {
        Muteado = !Muteado;

        MuteDesmute();

        PlayerPrefs.SetInt("MUTEADO", Muteado ? 0 : 1);

    }

    public void MuteDesmute()
    {


        if (Muteado)
        {
            AudioListener.volume = 1f;


            if (botonMusica != null)
            {
                Image imagenBoton = botonMusica.GetComponent<Image>();

                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteMuteado;
                }

            }
        }


        else
        {
            AudioListener.volume = 0f;

            

            if (botonMusica != null)
            {
                Image imagenBoton = botonMusica.GetComponent<Image>();
                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteDesmuteado;
                }

            }
        }

    }

}
