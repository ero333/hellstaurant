using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour
{
    public Puntaje Instance;


    public int puntos = 0;// PUNTAJE (NUMERO)
    private Text scoreText; //PUNTAJE (TEXTO)


    public int levelNumber;


    public Text scoreRecord;

    public EnemyBasicDamage enemyScript;

    public DataManager dataManager;


    public void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        levelNumber = SceneManager.GetActiveScene().buildIndex;
        puntos = 0;
        scoreRecord.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + levelNumber, puntos).ToString();
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = puntos.ToString("0");
    }

    public void obtenerPuntaje(int amount)
    {
        puntos += amount;


        dataManager.updateHighScore();

    }
}
