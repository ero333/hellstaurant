using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public Puntaje puntajeScript; //Script del puntaje//

    public int puntos; //Puntos llamados desde el script de puntaje//

    public int levelNumber;

    public Text scoreRecord;

    public static DataManager instance;

    public UIController uicontroller;







    public void Awake()
    {
        instance = this;
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreRecord = puntajeScript.scoreRecord;
        levelNumber = SceneManager.GetActiveScene().buildIndex;
        puntos = puntajeScript.puntos;
        scoreRecord.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + levelNumber, puntajeScript.puntos).ToString();;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void updateHighScore()
    {
        if (puntajeScript.puntos > PlayerPrefs.GetInt("PuntajeRecordLevel" + levelNumber, 0))
        {

            PlayerPrefs.SetInt("PuntajeRecordLevel" + levelNumber, puntajeScript.puntos);
            puntajeScript.scoreRecord.text = puntajeScript.puntos.ToString();
        }
    }
}
