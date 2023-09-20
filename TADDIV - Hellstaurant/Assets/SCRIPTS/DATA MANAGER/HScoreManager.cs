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
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(true);
            star3Level1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 499 )
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(true);
            star3Level1.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 299)
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(false);
            star3Level1.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 99)
        {
            star1Level1.SetActive(false);
            star2Level1.SetActive(false);
            star3Level1.SetActive(false);
        }


        //LEVEL 2//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 500)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(true);
            star3Level2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 499)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(true);
            star3Level2.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 299)
        {
            star1Level2.SetActive(true);
            star2Level2.SetActive(false);
            star3Level2.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 99)
        {
            star1Level2.SetActive(false);
            star2Level2.SetActive(false);
            star3Level2.SetActive(false);
        }


        //LEVEL 3//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 500)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(true);
            star3Level3.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 499)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(true);
            star3Level3.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 299)
        {
            star1Level3.SetActive(true);
            star2Level3.SetActive(false);
            star3Level3.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 99)
        {
            star1Level3.SetActive(false);
            star2Level3.SetActive(false);
            star3Level3.SetActive(false);
        }



        //LEVEL 4//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 500)
        {
            star1Level4.SetActive(true);
            star2Level4.SetActive(true);
            star3Level4.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 499)
        {
            star1Level4.SetActive(true);
            star2Level4.SetActive(true);
            star3Level4.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 299)
        {
            star1Level4.SetActive(true);
            star2Level4.SetActive(false);
            star3Level4.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 99)
        {
            star1Level4.SetActive(false);
            star2Level4.SetActive(false);
            star3Level4.SetActive(false);
        }



        //LEVEL 5//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 500)
        {
            star1Level5.SetActive(true);
            star2Level5.SetActive(true);
            star3Level5.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 499)
        {
            star1Level5.SetActive(true);
            star2Level5.SetActive(true);
            star3Level5.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 299)
        {
            star1Level5.SetActive(true);
            star2Level5.SetActive(false);
            star3Level5.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 99)
        {
            star1Level5.SetActive(false);
            star2Level5.SetActive(false);
            star3Level5.SetActive(false);
        }



        //LEVEL 6//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 500)
        {
            star1Level6.SetActive(true);
            star2Level6.SetActive(true);
            star3Level6.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 499)
        {
            star1Level6.SetActive(true);
            star2Level6.SetActive(true);
            star3Level6.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 299)
        {
            star1Level6.SetActive(true);
            star2Level6.SetActive(false);
            star3Level6.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 99)
        {
            star1Level6.SetActive(false);
            star2Level6.SetActive(false);
            star3Level6.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }


}
