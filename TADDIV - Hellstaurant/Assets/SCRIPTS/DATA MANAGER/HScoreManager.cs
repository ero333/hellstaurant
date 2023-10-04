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

    public Text highscoreLevel8;

    public Text highscoreLevel9;

    public Text highscoreLevel10;

    public Text highscoreLevel11;

    public Text highscoreLevel12;


    public GameObject star1Level1, star2Level1, star3Level1;
    public GameObject star1Level2, star2Level2, star3Level2;
    public GameObject star1Level3, star2Level3, star3Level3;
    public GameObject star1Level4, star2Level4, star3Level4;
    public GameObject star1Level5, star2Level5, star3Level5;
    public GameObject star1Level6, star2Level6, star3Level6;
    public GameObject star1Level7, star2Level7, star3Level7;
    public GameObject star1Level8, star2Level8, star3Level8;
    public GameObject star1Level9, star2Level9, star3Level9;
    public GameObject star1Level10, star2Level10, star3Level10;
    public GameObject star1Level11, star2Level11, star3Level11;
    public GameObject star1Level12, star2Level12, star3Level12;



    // Start is called before the first frame update
    void Start()
    {
        highscoreLevel2.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 5, 0).ToString();
        highscoreLevel3.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 6, 0).ToString();
        highscoreLevel4.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 7, 0).ToString();
        highscoreLevel5.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 9, 0).ToString();
        highscoreLevel6.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 10, 0).ToString();
        highscoreLevel7.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 11, 0).ToString();
        highscoreLevel8.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 12, 0).ToString();
        highscoreLevel9.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 13, 0).ToString();
        highscoreLevel10.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 14, 0).ToString();
        highscoreLevel11.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 14, 0).ToString();
        highscoreLevel12.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 14, 0).ToString();


        //LEVEL 1//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level1.SetActive(true);
            star2Level1.SetActive(true);
            star3Level1.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 499)
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


        //LEVEL 7//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 500)
        {
            star1Level7.SetActive(true);
            star2Level7.SetActive(true);
            star3Level7.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 499)
        {
            star1Level7.SetActive(true);
            star2Level7.SetActive(true);
            star3Level7.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 299)
        {
            star1Level7.SetActive(true);
            star2Level7.SetActive(false);
            star3Level7.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 99)
        {
            star1Level7.SetActive(false);
            star2Level7.SetActive(false);
            star3Level7.SetActive(false);
        }



        //LEVEL 8//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 500)
        {
            star1Level8.SetActive(true);
            star2Level8.SetActive(true);
            star3Level8.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 499)
        {
            star1Level8.SetActive(true);
            star2Level8.SetActive(true);
            star3Level8.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 299)
        {
            star1Level8.SetActive(true);
            star2Level8.SetActive(false);
            star3Level8.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 99)
        {
            star1Level8.SetActive(false);
            star2Level8.SetActive(false);
            star3Level8.SetActive(false);
        }


        //LEVEL 9//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 500)
        {
            star1Level9.SetActive(true);
            star2Level9.SetActive(true);
            star3Level9.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 499)
        {
            star1Level9.SetActive(true);
            star2Level9.SetActive(true);
            star3Level9.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 299)
        {
            star1Level9.SetActive(true);
            star2Level9.SetActive(false);
            star3Level9.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 99)
        {
            star1Level9.SetActive(false);
            star2Level9.SetActive(false);
            star3Level9.SetActive(false);
        }

        //LEVEL 10//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level10.SetActive(true);
            star2Level10.SetActive(true);
            star3Level10.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 499)
        {
            star1Level10.SetActive(true);
            star2Level10.SetActive(true);
            star3Level10.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 299)
        {
            star1Level10.SetActive(true);
            star2Level10.SetActive(false);
            star3Level10.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 99)
        {
            star1Level10.SetActive(false);
            star2Level10.SetActive(false);
            star3Level10.SetActive(false);
        }

        //LEVEL 11//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level11.SetActive(true);
            star2Level11.SetActive(true);
            star3Level11.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 499)
        {
            star1Level11.SetActive(true);
            star2Level11.SetActive(true);
            star3Level11.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 299)
        {
            star1Level11.SetActive(true);
            star2Level11.SetActive(false);
            star3Level11.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 99)
        {
            star1Level11.SetActive(false);
            star2Level11.SetActive(false);
            star3Level11.SetActive(false);
        }

        //LEVEL 12//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 500)
        {
            star1Level12.SetActive(true);
            star2Level12.SetActive(true);
            star3Level12.SetActive(true);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 499)
        {
            star1Level12.SetActive(true);
            star2Level12.SetActive(true);
            star3Level12.SetActive(false);
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 299)
        {
            star1Level12.SetActive(true);
            star2Level12.SetActive(false);
            star3Level12.SetActive(false);
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 99)
        {
            star1Level12.SetActive(false);
            star2Level12.SetActive(false);
            star3Level12.SetActive(false);
        }
    }
}
