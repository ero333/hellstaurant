using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HScoreManager : MonoBehaviour
{

    public Text highscoreLevel2;

    public Text highscoreLevel3;

    public Text highscoreLevel4;

    public Text highscoreLevel5;

    public Text highscoreLevel6;

    public Text highscoreLevel7;

    public GameObject star1Level1, star2Level1, star3Level1;
    public GameObject star1Level2, star2Level2, star3Level2;
    public GameObject star1Level3, star2Level3, star3Level3;
    public GameObject star1Level4, star2Level4, star3Level4;
    public GameObject star1Level5, star2Level5, star3Level5;
    public GameObject star1Level6, star2Level6, star3Level6;



    // Start is called before the first frame update
    void Start()
    {
        highscoreLevel2.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 3, 0).ToString();
        highscoreLevel3.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 4, 0).ToString();
        highscoreLevel4.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 5, 0).ToString();
        highscoreLevel5.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 7, 0).ToString();
        highscoreLevel6.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 8, 0).ToString();
        highscoreLevel7.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 9, 0).ToString();


        //LEVEL 1//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) >= 500)
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(true);
            star3Level1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) <= 499 )
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(true);
            star3Level1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) <= 299)
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(false);
            star3Level1.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 3) <= 99)
        {
            star1Level1.SetActive(false);
            star2Level1.SetActive(false);
            star3Level1.SetActive(false);
        }


        //LEVEL 2//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) >= 500)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(true);
            star3Level2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) <= 499)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(true);
            star3Level2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) <= 299)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(false);
            star3Level2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 4) <= 99)
        {
            star1Level2.SetActive(false);
            star2Level2.SetActive(false);
            star3Level2.SetActive(false);
        }


        //LEVEL 3//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(true);
            star3Level3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 2) <= 499)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(true);
            star3Level3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 2) <= 299)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(false);
            star3Level3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 2) <= 99)
        {
            star1Level3.SetActive(false);
            star2Level3.SetActive(false);
            star3Level3.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


}
