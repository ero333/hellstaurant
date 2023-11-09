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

    public Text highscoreLevel13;

    public Text highscoreLevel14;


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
    public GameObject star1Level14, star2Level14, star3Level14;



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
        highscoreLevel11.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 15, 0).ToString();
        highscoreLevel12.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 16, 0).ToString();
        highscoreLevel13.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 17, 0).ToString();
        highscoreLevel14.text = PlayerPrefs.GetInt("PuntajeRecordLevel" + 19, 0).ToString();


        //LEVEL 1//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 100)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 5)
            {
                star1Level1.SetActive(true);
                star2Level1.SetActive(true);
                star3Level1.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 60 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 99)
        {

            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 5)
            {
                star1Level1.SetActive(true);
                star2Level1.SetActive(true);
                star3Level1.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 20 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 60)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 5)
            {
                star1Level1.SetActive(true);
                star2Level1.SetActive(false);
                star3Level1.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 5) <= 19)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 5)
            {
                star1Level1.SetActive(false);
                star2Level1.SetActive(false);
                star3Level1.SetActive(false);

            }
        }


        //LEVEL 2//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 200)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 6)
            {
                star1Level2.SetActive(true);
                star2Level2.SetActive(true);
                star3Level2.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 80 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 199)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 6)
            {
                star1Level2.SetActive(true);
                star2Level2.SetActive(true);
                star3Level2.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 60 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 80)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 6)
            {
                star1Level2.SetActive(true);
                star2Level2.SetActive(false);
                star3Level2.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 6) <= 59)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 6)
            {
                star1Level2.SetActive(false);
                star2Level2.SetActive(false);
                star3Level2.SetActive(false);

            }
        }


        //LEVEL 3//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 300)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 7)
            {
                star1Level3.SetActive(true);
                star2Level3.SetActive(true);
                star3Level3.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 299)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 7)
            {
                star1Level3.SetActive(true);
                star2Level3.SetActive(true);
                star3Level3.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 60 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 99)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 7)
            {
                star1Level3.SetActive(true);
                star2Level3.SetActive(false);
                star3Level3.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 7) <= 59)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 7)
            {
                star1Level3.SetActive(false);
                star2Level3.SetActive(false);
                star3Level3.SetActive(false);

            }
        }



        //LEVEL 4//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 400)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 9)
            {
                star1Level4.SetActive(true);
                star2Level4.SetActive(true);
                star3Level4.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 200 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 9)
            {
                star1Level4.SetActive(true);
                star2Level4.SetActive(true);
                star3Level4.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 100 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 199)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 9)
            {
                star1Level4.SetActive(true);
                star2Level4.SetActive(false);
                star3Level4.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 9) <= 99)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 9)
            {
                star1Level4.SetActive(false);
                star2Level4.SetActive(false);
                star3Level4.SetActive(false);

            }
        }



        //LEVEL 5//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 520)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 10)
            {
                star1Level5.SetActive(true);
                star2Level5.SetActive(true);
                star3Level5.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 519)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 10)
            {
                star1Level5.SetActive(true);
                star2Level5.SetActive(true);
                star3Level5.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 150 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 299)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 10)
            {
                star1Level5.SetActive(true);
                star2Level5.SetActive(false);
                star3Level5.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 10) <= 149)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 10)
            {
                star1Level5.SetActive(false);
                star2Level5.SetActive(false);
                star3Level5.SetActive(false);

            }
        }



        //LEVEL 6//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 520)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 11)
            {
                star1Level6.SetActive(true);
                star2Level6.SetActive(true);
                star3Level6.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 519)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 11)
            {
                star1Level6.SetActive(true);
                star2Level6.SetActive(true);
                star3Level6.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 150 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 299)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 11)
            {
                star1Level6.SetActive(true);
                star2Level6.SetActive(false);
                star3Level6.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 11) <= 149)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 11)
            {
                star1Level6.SetActive(false);
                star2Level6.SetActive(false);
                star3Level6.SetActive(false);

            }
        }


        //LEVEL 7//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 700)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 12)
            {
                star1Level7.SetActive(true);
                star2Level7.SetActive(true);
                star3Level7.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 500 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 699)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 12)
            {
                star1Level7.SetActive(true);
                star2Level7.SetActive(true);
                star3Level7.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 499)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 12)
            {
                star1Level7.SetActive(true);
                star2Level7.SetActive(false);
                star3Level7.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 12) <= 299)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 12)
            {
                star1Level7.SetActive(false);
                star2Level7.SetActive(false);
                star3Level7.SetActive(false);

            }
        }



        //LEVEL 8//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 700)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 13)
            {
                star1Level8.SetActive(true);
                star2Level8.SetActive(true);
                star3Level8.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 500 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 699)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 13)
            {
                star1Level8.SetActive(true);
                star2Level8.SetActive(true);
                star3Level8.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 300 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 499)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 13)
            {
                star1Level8.SetActive(true);
                star2Level8.SetActive(false);
                star3Level8.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 13) <= 299)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 13)
            {
                star1Level8.SetActive(false);
                star2Level8.SetActive(false);
                star3Level8.SetActive(false);

            }
        }


        //LEVEL 9//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 900)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 14)
            {
                star1Level9.SetActive(true);
                star2Level9.SetActive(true);
                star3Level9.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 600 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 899)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 14)
            {
                star1Level9.SetActive(true);
                star2Level9.SetActive(true);
                star3Level9.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 400 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 599)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 14)
            {
                star1Level9.SetActive(true);
                star2Level9.SetActive(false);
                star3Level9.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 14) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 14)
            {
                star1Level9.SetActive(false);
                star2Level9.SetActive(false);
                star3Level9.SetActive(false);

            }
        }

        //LEVEL 10//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) >= 900)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 15)
            {
                star1Level10.SetActive(true);
                star2Level10.SetActive(true);
                star3Level10.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) >= 600 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) <= 899)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 15)
            {
                star1Level10.SetActive(true);
                star2Level10.SetActive(true);
                star3Level10.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) >= 400 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) <= 599)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 15)
            {
                star1Level10.SetActive(true);
                star2Level10.SetActive(false);
                star3Level10.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 15) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 15)
            {
                star1Level10.SetActive(false);
                star2Level10.SetActive(false);
                star3Level10.SetActive(false);

            }
        }

        //LEVEL 11//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) >= 900)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 16)
            {
                star1Level11.SetActive(true);
                star2Level11.SetActive(true);
                star3Level11.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) >= 600 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) <= 899)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 16)
            {
                star1Level11.SetActive(true);
                star2Level11.SetActive(true);
                star3Level11.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) >= 400 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) <= 599)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 16)
            {
                star1Level11.SetActive(true);
                star2Level11.SetActive(false);
                star3Level11.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 16) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 16)
            {
                star1Level11.SetActive(false);
                star2Level11.SetActive(false);
                star3Level11.SetActive(false);

            }
        }

        //LEVEL 12//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) >= 900)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 17)
            {
                star1Level12.SetActive(true);
                star2Level12.SetActive(true);
                star3Level12.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) >= 600 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) <= 899)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 17)
            {
                star1Level12.SetActive(true);
                star2Level12.SetActive(true);
                star3Level12.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) >= 400 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) <= 599)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 17)
            {
                star1Level12.SetActive(true);
                star2Level12.SetActive(false);
                star3Level12.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 17) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 17)
            {
                star1Level12.SetActive(false);
                star2Level12.SetActive(false);
                star3Level12.SetActive(false);

            }
        }


        //JEFE//
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) >= 900)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 19)
            {
                star1Level14.SetActive(true);
                star2Level14.SetActive(true);
                star3Level14.SetActive(true);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) >= 600 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) <= 899)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 19)
            {
                star1Level14.SetActive(true);
                star2Level14.SetActive(true);
                star3Level14.SetActive(false);

            }
        }
        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) >= 400 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) <= 599)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 19)
            {
                star1Level14.SetActive(true);
                star2Level14.SetActive(false);
                star3Level14.SetActive(false);

            }
        }

        if (PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) >= 0 && PlayerPrefs.GetInt("PuntajeRecordLevel" + 19) <= 399)
        {
            if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 19)
            {
                star1Level14.SetActive(false);
                star2Level14.SetActive(false);
                star3Level14.SetActive(false);

            }
        }
    }
}
