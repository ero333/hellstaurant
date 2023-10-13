using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelStart : MonoBehaviour
{

    public static levelStart instance;

    public long leveltimer;

    public float DeltaTime;

    public float seconds = 1.0f;

    public bool timerRunning;

    public int level;

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

    public void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times1);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.skip = " + PlayerPrefs.GetInt("LevelStart.skip = "));
            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times2);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times3);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times4);
            Debug.Log("LevelStart.first = " + firstTime);

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

            Debug.Log("LevelStart.skip = " + PlayerPrefs.GetInt("LevelStart.skip = "));
            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times5);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times6);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times7);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times8);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times9);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times10);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times11);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times12);
            Debug.Log("LevelStart.first = " + firstTime);
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times13);
            Debug.Log("LevelStart.first = " + firstTime);
        }

        if (SceneManager.GetActiveScene().name == "Nivel 13")
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times14);
            Debug.Log("LevelStart.first = " + firstTime);
        }

        if (SceneManager.GetActiveScene().name == "Nivel Final")
        {
            level = 15;
            times15 ++ ;
            PlayerPrefs.SetInt("LevelStart.level15.times = ", times15);

            if (times15 == 1)
            {
                firstTime = true;
            }
            else
            {
                firstTime = false;
            }

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times15);
            Debug.Log("LevelStart.first = " + firstTime);
        }

        if (SceneManager.GetActiveScene().name == "Endless")
        {
            level = 16;
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

            Debug.Log("LevelStart.level = " + level);
            Debug.Log("LevelStart.times = " + times16);
            Debug.Log("LevelStart.first = " + firstTime);
        }

        skinSe = PlayerPrefs.GetString("skin seleccionada");
        Debug.Log("LevelStart.skinSe = " + skinSe);
         
        

    }

    public void saltear()
    {
        skip = true;
        PlayerPrefs.SetInt("LevelStart.skip = " , 1);
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
            Debug.Log("GameOver.time = " + leveltimer);
            Debug.Log("GameOver.level = " + level);
        }
    }
}
