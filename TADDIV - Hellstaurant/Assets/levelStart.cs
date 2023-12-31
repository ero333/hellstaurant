using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using Unity.Services.Core;

public class levelStart : MonoBehaviour
{

    public static levelStart instance;

    public long leveltimer;

    public float DeltaTime;

    public float seconds = 1.0f;

    public bool timerRunning;

    public int level;

    public int times;

    public int times1 = 0;

    public int times2 = 0;

    public int times3 = 0;

    public int times4 = 0;

    public int times5 = 0;

    public int times6 = 0;

    public int times7 = 0;

    public int times8 = 0;

    public int times9 = 0;

    public int times10 = 0;

    public int times11 = 0;

    public int times12 = 0;

    public int times13 = 0;

    public int times14 = 0;

    public int times15 = 0;

    public int times16 = 0;

    public string skinSe;

    public bool firstTime;

    public bool skip;

    public bool bossDefeated = false;

    public levelStart levelstart;

    public void Awake()
    {
        instance = this;

        UnityServices.InitializeAsync();

    }
    // Start is called before the first frame update
    void Start()
    {

        skinSe = PlayerPrefs.GetString("skin seleccionada");
       


        leveltimer = 0;

        timerRunning = true;


        times1 = PlayerPrefs.GetInt("LevelStart.level1.times = ");
        times2 = PlayerPrefs.GetInt("LevelStart.level2.times = ");
        times3 = PlayerPrefs.GetInt("LevelStart.level3.times = ");
        times4 = PlayerPrefs.GetInt("LevelStart.level4.times = ");
        times5 = PlayerPrefs.GetInt("LevelStart.level5.times = ");
        times6 = PlayerPrefs.GetInt("LevelStart.level6.times = ");
        times7 = PlayerPrefs.GetInt("LevelStart.level7.times = ");
        times8 = PlayerPrefs.GetInt("LevelStart.level8.times = ");
        times9 = PlayerPrefs.GetInt("LevelStart.level9.times = ");
        times10 = PlayerPrefs.GetInt("LevelStart.level10.times = ");
        times11 = PlayerPrefs.GetInt("LevelStart.level11.times = ");
        times12 = PlayerPrefs.GetInt("LevelStart.level12.times = ");
        times13 = PlayerPrefs.GetInt("LevelStart.level13.times = ");
        times14 = PlayerPrefs.GetInt("LevelStart.level14.times = ");
        times15 = PlayerPrefs.GetInt("LevelStart.level15.times = ");
        times16 = PlayerPrefs.GetInt("LevelStart.level16.times = ");

        if (SceneManager.GetActiveScene().name == "Nivel 0 (tutorial)")
        {
            level = 1;
            times1 ++ ;

            PlayerPrefs.SetInt("LevelStart.level1.times = " , times1);

            
            
            if (times1 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }

            times = times1;

            
        }

        if (SceneManager.GetActiveScene().name == "Nivel 1")
        {
            level = 2;

            times2 ++ ;

            PlayerPrefs.SetInt("LevelStart.level2.times = ", times2);

            if (times2 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }

            times = times2;

            Debug.Log("LevelStart.skip = " + PlayerPrefs.GetInt("LevelStart.skip = "));


        }

        if (SceneManager.GetActiveScene().name == "Nivel 2")
        {
            level = 3;

            times3 ++ ;
            PlayerPrefs.SetInt("LevelStart.level3.times = ", times3);

            if (times3 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }

            times = times3;



        }

        if (SceneManager.GetActiveScene().name == "Nivel 3")
        {
            level = 4;
            times4 ++ ;
            PlayerPrefs.SetInt("LevelStart.level4.times = ", times4);

            if (times4 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times4;


        }

        if (SceneManager.GetActiveScene().name == "Nivel 4")
        {
            level = 5;
            times5 ++ ;
            PlayerPrefs.SetInt("LevelStart.level5.times = ", times5);

            if (times5 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times5;

            Debug.Log("LevelStart.skip = " + PlayerPrefs.GetInt("LevelStart.skip = "));


        }

        if (SceneManager.GetActiveScene().name == "Nivel 5")
        {
            level = 6;
            times6 ++ ;
            PlayerPrefs.SetInt("LevelStart.level6.times = ", times6);

            if (times6 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }



            times = times6;

        }

        if (SceneManager.GetActiveScene().name == "Nivel 6")
        {
            level = 7;
            times7 ++ ;
            PlayerPrefs.SetInt("LevelStart.level7.times = ", times7);

            if (times7 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times7;



        }

        if (SceneManager.GetActiveScene().name == "Nivel 7")
        {
            level = 8;
            times8 ++ ;
            PlayerPrefs.SetInt("LevelStart.level8.times = ", times8);

            if (times8 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times8;



        }

        if (SceneManager.GetActiveScene().name == "Nivel 8")
        {
            level = 9;
            times9 ++ ;
            PlayerPrefs.SetInt("LevelStart.level9.times = ", times9);

            if (times9 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times9;


        }

        if (SceneManager.GetActiveScene().name == "Nivel 9")
        {
            level = 10;
            times10 ++ ;
            PlayerPrefs.SetInt("LevelStart.level10.times = ", times10);

            if (times10 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times10;



        }

        if (SceneManager.GetActiveScene().name == "Nivel 10")
        {
            level = 11;
            times11 ++ ;
            PlayerPrefs.SetInt("LevelStart.level11.times = ", times11);

            if (times11 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times11;



        }

        if (SceneManager.GetActiveScene().name == "Nivel 11")
        {
            level = 12;
            times12 ++ ;
            PlayerPrefs.SetInt("LevelStart.level12.times = ", times12);

            if (times12 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times12;


        }

        if (SceneManager.GetActiveScene().name == "Nivel 12")
        {
            level = 13;
            times13 ++ ;
            PlayerPrefs.SetInt("LevelStart.level13.times = ", times13);

            if (times13 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times13;


        }

        if (SceneManager.GetActiveScene().name == "Nivel Final")
        {
            level = 14;
            times14 ++ ;
            PlayerPrefs.SetInt("LevelStart.level14.times = " , times14);

            if (times14 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times14;


        }


        if (SceneManager.GetActiveScene().name == "Endless")
        {
            level = 15;
            times16 ++ ;
            PlayerPrefs.SetInt("LevelStart.level16.times = ", times16);

            if (times16 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }


            times = times15;


        }


        Debug.Log("LevelStart.skinSe = " + skinSe);

        Debug.Log("LevelStart.level = " + level);
        Debug.Log("LevelStart.times = " + times);
        Debug.Log("LevelStart.first = " + firstTime);


        AnalyticsService.Instance.CustomData("LevelStart", new Dictionary<string, object>
            {
            { "level", level },
            { "times", times },
            { "first", firstTime },
            { "skinSe", skinSe }
            });
    }

    public void saltear()
    {
        skip = true;
        PlayerPrefs.SetInt("LevelStart.skip = " , 1);


        AnalyticsService.Instance.CustomData("LevelStart", new Dictionary<string, object>
            {
            { "skip", skip },
            });
    }


    // Update is called once per frame
    void Update()
    {
        if (timerRunning)
        {
            DeltaTime += Time.deltaTime;

            if (DeltaTime >= seconds)
            {
                leveltimer++;
                DeltaTime = 0;
            }
        }

        if (!timerRunning)
        {
            timerRunning = true;
        }

        if (bossDefeated) 
        {
            Debug.Log("LevelComplete.time = " + leveltimer);

            AnalyticsService.Instance.CustomData("LevelComplete", new Dictionary<string, object>
            {
                {"time", leveltimer },
            });


           bossDefeated = false;
        }
    }
}
