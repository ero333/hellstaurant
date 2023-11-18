using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class RateController : MonoBehaviour
{
    public int puntuation;
    public int puntuationGame;
    public string note;
    public string noteGame;

    public int lastlevel;

    public GameObject botonRate;
    public int rateado;
    public GameObject popupRate;

    public GameObject botonJugar;

    public Sprite estrellavacia;
    public Sprite estrellallena;

    public int ratinggame;
    public int ratingart;

    public GameObject botonSend;

    [Header("botones estrellas juego")]
    public Button estrella1;
    public Button estrella2;
    public Button estrella3;
    public Button estrella4;
    public Button estrella5;

    [Header("botones estrellas arte")]
    public Button estrellart1;
    public Button estrellart2;
    public Button estrellart3;
    public Button estrellart4;
    public Button estrellart5;

    public AudioSource buttonsound;

    void Start()
    {
        botonSend.SetActive(false);

        buttonsound = GameObject.FindGameObjectWithTag ("sonidoboton").GetComponent<AudioSource> ();

        rateado = PlayerPrefs.GetInt("rateado");
        popupRate.SetActive(false);

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 4)
        {
            lastlevel = 1;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 5)
        {
            lastlevel = 2;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 6)
        {
            lastlevel = 3;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 7)
        {
            lastlevel = 4;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 9)
        {
            lastlevel = 5;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 10)
        {
            lastlevel = 6;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 11)
        {
            lastlevel = 7;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 12)
        {
            lastlevel = 8;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 13)
        {
            lastlevel = 9;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 14)
        {
            lastlevel = 10;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 15)
        {
            lastlevel = 11;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 16)
        {
            lastlevel = 12;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 17)
        {
            lastlevel = 13;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 18)
        {
            lastlevel = 14;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 20)
        {
            lastlevel = 15;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 22)
        {
            lastlevel = 16;
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (ratingart >= 1 && ratinggame >=1)
        {
            botonSend.SetActive(true);
        }

        if(rateado >= 1)
        {
            botonRate.SetActive(false);
        }


    }

    public void UnoEstrella()
    {
        
        Image estrella1image=estrella1.GetComponent<Image>();
        Image estrella2image = estrella2.GetComponent<Image>();
        Image estrella3image = estrella3.GetComponent<Image>();
        Image estrella4image = estrella4.GetComponent<Image>();
        Image estrella5image = estrella5.GetComponent<Image>();


        estrella1image.sprite = estrellallena;
        estrella2image.sprite = estrellavacia;
        estrella3image.sprite = estrellavacia;
        estrella4image.sprite = estrellavacia;
        estrella5image.sprite = estrellavacia;

        ratinggame = 1;

        puntuationGame = 1;
        noteGame = "HORRIBLE";
    }

    public void DosEstrella()
    {

        Image estrella1image = estrella1.GetComponent<Image>();
        Image estrella2image = estrella2.GetComponent<Image>();
        Image estrella3image = estrella3.GetComponent<Image>();
        Image estrella4image = estrella4.GetComponent<Image>();
        Image estrella5image = estrella5.GetComponent<Image>();


        estrella1image.sprite = estrellallena;
        estrella2image.sprite = estrellallena;
        estrella3image.sprite = estrellavacia;
        estrella4image.sprite = estrellavacia;
        estrella5image.sprite = estrellavacia;

        ratinggame = 2;

        puntuationGame = 2;
        noteGame = "MALO";
    }

    public void TresEstrella()
    {

        Image estrella1image = estrella1.GetComponent<Image>();
        Image estrella2image = estrella2.GetComponent<Image>();
        Image estrella3image = estrella3.GetComponent<Image>();
        Image estrella4image = estrella4.GetComponent<Image>();
        Image estrella5image = estrella5.GetComponent<Image>();


        estrella1image.sprite = estrellallena;
        estrella2image.sprite = estrellallena;
        estrella3image.sprite = estrellallena;
        estrella4image.sprite = estrellavacia;
        estrella5image.sprite = estrellavacia;

        ratinggame = 3;

        puntuationGame = 3;
        noteGame = "NEUTRAL";
    }

    public void CuatroEstrella()
    {

        Image estrella1image = estrella1.GetComponent<Image>();
        Image estrella2image = estrella2.GetComponent<Image>();
        Image estrella3image = estrella3.GetComponent<Image>();
        Image estrella4image = estrella4.GetComponent<Image>();
        Image estrella5image = estrella5.GetComponent<Image>();


        estrella1image.sprite = estrellallena;
        estrella2image.sprite = estrellallena;
        estrella3image.sprite = estrellallena;
        estrella4image.sprite = estrellallena;
        estrella5image.sprite = estrellavacia;

        ratinggame = 4;

        puntuationGame = 4;
        noteGame = "BUENO";
    }

    public void CincoEstrella()
    {

        Image estrella1image = estrella1.GetComponent<Image>();
        Image estrella2image = estrella2.GetComponent<Image>();
        Image estrella3image = estrella3.GetComponent<Image>();
        Image estrella4image = estrella4.GetComponent<Image>();
        Image estrella5image = estrella5.GetComponent<Image>();


        estrella1image.sprite = estrellallena;
        estrella2image.sprite = estrellallena;
        estrella3image.sprite = estrellallena;
        estrella4image.sprite = estrellallena;
        estrella5image.sprite = estrellallena;

        ratinggame = 5;

        puntuationGame = 5;
        noteGame = "EXCELENTE";
    }

    //arte

    public void UnoEstrellart()
    {

        Image estrellart1image = estrellart1.GetComponent<Image>();
        Image estrellart2image = estrellart2.GetComponent<Image>();
        Image estrellart3image = estrellart3.GetComponent<Image>();
        Image estrellart4image = estrellart4.GetComponent<Image>();
        Image estrellart5image = estrellart5.GetComponent<Image>();


        estrellart1image.sprite = estrellallena;
        estrellart2image.sprite = estrellavacia;
        estrellart3image.sprite = estrellavacia;
        estrellart4image.sprite = estrellavacia;
        estrellart5image.sprite = estrellavacia;

        ratingart = 1;

        puntuation = 1;
        note = "HORRIBLE";
    }

    public void DosEstrellart()
    {

        Image estrellart1image = estrellart1.GetComponent<Image>();
        Image estrellart2image = estrellart2.GetComponent<Image>();
        Image estrellart3image = estrellart3.GetComponent<Image>();
        Image estrellart4image = estrellart4.GetComponent<Image>();
        Image estrellart5image = estrellart5.GetComponent<Image>();


        estrellart1image.sprite = estrellallena;
        estrellart2image.sprite = estrellallena;
        estrellart3image.sprite = estrellavacia;
        estrellart4image.sprite = estrellavacia;
        estrellart5image.sprite = estrellavacia;

        ratingart = 2;


        puntuation = 2;
        note = "MALO";
    }

    public void TresEstrellart()
    {

        Image estrellart1image = estrellart1.GetComponent<Image>();
        Image estrellart2image = estrellart2.GetComponent<Image>();
        Image estrellart3image = estrellart3.GetComponent<Image>();
        Image estrellart4image = estrellart4.GetComponent<Image>();
        Image estrellart5image = estrellart5.GetComponent<Image>();


        estrellart1image.sprite = estrellallena;
        estrellart2image.sprite = estrellallena;
        estrellart3image.sprite = estrellallena;
        estrellart4image.sprite = estrellavacia;
        estrellart5image.sprite = estrellavacia;

        ratingart = 3;


        puntuation = 3;
        note = "NEUTRAL";
    }

    public void CuatroEstrellart()
    {

        Image estrellart1image = estrellart1.GetComponent<Image>();
        Image estrellart2image = estrellart2.GetComponent<Image>();
        Image estrellart3image = estrellart3.GetComponent<Image>();
        Image estrellart4image = estrellart4.GetComponent<Image>();
        Image estrellart5image = estrellart5.GetComponent<Image>();


        estrellart1image.sprite = estrellallena;
        estrellart2image.sprite = estrellallena;
        estrellart3image.sprite = estrellallena;
        estrellart4image.sprite = estrellallena;
        estrellart5image.sprite = estrellavacia;

        ratingart = 4;


        puntuation = 4;
        note = "BUENO";
    }

    public void CincoEstrellart()
    {

        Image estrellart1image = estrellart1.GetComponent<Image>();
        Image estrellart2image = estrellart2.GetComponent<Image>();
        Image estrellart3image = estrellart3.GetComponent<Image>();
        Image estrellart4image = estrellart4.GetComponent<Image>();
        Image estrellart5image = estrellart5.GetComponent<Image>();


        estrellart1image.sprite = estrellallena;
        estrellart2image.sprite = estrellallena;
        estrellart3image.sprite = estrellallena;
        estrellart4image.sprite = estrellallena;
        estrellart5image.sprite = estrellallena;

        ratingart = 5;


        puntuation = 5;
        note = "EXCELENTE";
    }

    public void sendRate()
    {
        
        if (buttonsound != null)
        {

            buttonsound.Play();
        }


        Debug.Log("RateGame.puntuation =" + puntuationGame);
        Debug.Log("RateArt.puntuation =" + puntuation);

        Debug.Log("RateGame.note =" + noteGame);
        Debug.Log("RateArt.note =" + note);

        Debug.Log("RateGame.lastLevel =" + lastlevel);
        Debug.Log("RateArte.lastLevel =" + lastlevel);

        PlayerPrefs.SetInt("RateGame.puntuation =", puntuationGame);
        PlayerPrefs.SetInt("RateArt.puntuation =", puntuation);

        PlayerPrefs.SetString("RateGame.note =", noteGame);
        PlayerPrefs.SetString("RateArt.note =", note);

        PlayerPrefs.SetInt("RateGame.lastLevel =", lastlevel);
        PlayerPrefs.SetInt("RateArt.lastLevel =", lastlevel);

        PlayerPrefs.SetInt("puntajeJuego =", ratinggame);

        PlayerPrefs.SetInt("puntajeArte =", ratingart);

        popupRate.SetActive(false);
        botonRate.SetActive(false);
        PlayerPrefs.SetInt("rateado", 1);


        AnalyticsService.Instance.CustomData("RateGame", new Dictionary<string, object>
            {
            { "puntuation", puntuationGame },
             { "lastLevel", lastlevel },
              { "note", noteGame },
            });


        AnalyticsService.Instance.CustomData("RateArt", new Dictionary<string, object>
            {
            { "puntuation", puntuation },
             { "lastLevel", lastlevel },
              { "note", note },
            });
    }

        public void cerrarRate()
    {


        EventSystem.current.SetSelectedGameObject(estrella1.GetComponentInChildren<Button>().gameObject);

        popupRate.SetActive(false);
    }

    public void abrirRate()
    {


        EventSystem.current.SetSelectedGameObject(botonJugar.GetComponentInChildren<Button>().gameObject);
        popupRate.SetActive(true); 
    }


}


