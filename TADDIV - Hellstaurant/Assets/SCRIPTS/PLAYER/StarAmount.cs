using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Services.Analytics;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class StarAmount : MonoBehaviour
{
    public Puntaje puntaje;
    public GameObject star1, star2, star3;

    public  PlayerHealthController healthController;

    public static int stars;

    public static int level;

    public bool bossDefeated = false;

    public levelStart levelstart;

    public int lastlevel;

    public achievementManager achievementObject;

    public int noHitCounter;

    public int noHitLevelCount;

    public PlayerShooting shooting;

    public int noShootGot = 0;

    public int noHealCount;


    [Header("variables diccionario")]

    public static int healing;
    public static int hit;
    public static int basicoHit;
    public static int basicoPHit;
    public static int gordoHit;
    public static int gordoPHit;
    public static int rapidoHit;
    public static int rapidoPHit;
    public static int rodeteHit;
    public static int rodetePHit;
    public static int aranaHit;
    public static int cucarachaHit;
    public static int jefeHit;



    Dictionary<string, object> DatosEndgame = new Dictionary<string, object>()
{
           {"level", level },
           {"stars", stars},
           {"healing", healing},
           {"hit", hit},
           {"basicoHit", basicoHit},
           {"basicoPHit", basicoPHit},
           {"gordoHit", gordoHit},
           {"gordoPHit", gordoPHit},
           {"rapidoHit", rapidoHit},
           {"rapidoPHit", rapidoPHit},
           {"rodeteHit", rodeteHit},
           {"rodetePHit", rodetePHit},
           {"aranaHit", aranaHit},
           {"cucarachaHit", cucarachaHit},
           {"jefeHit", jefeHit}
};


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        noHealCount = PlayerPrefs.GetInt("noheal");
    }

    public void Start()
    {
        noHealCount = PlayerPrefs.GetInt ("noheal");

        noShootGot = PlayerPrefs.GetInt("NoShooting");
        shooting = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerShooting>();
        noHitCounter = PlayerPrefs.GetInt("NOHITBOSS");
        noHitLevelCount = PlayerPrefs.GetInt("NOHIT");

        achievementObject = GameObject.FindGameObjectWithTag("achievementManager").GetComponent<achievementManager>();

        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);


        healing = healthController.healingTimes;
        hit = healthController.hit;
        basicoHit = healthController.basicoHit;
        basicoPHit = healthController.basicoPHit;
        gordoHit = healthController.gordoHit;
        gordoPHit = healthController.gordoPHit;
        rapidoHit = healthController.rapidoHit;
        rapidoPHit = healthController.rapidoPHit;
        rodeteHit = healthController.rodeteHit;
        rodetePHit = healthController.rodetePHit;
        aranaHit = healthController.aranaHit;
        cucarachaHit = healthController.cucarachaHit;
        jefeHit = healthController.bossHit;




        switch (PlayerPrefs.GetInt("NivelActual"))
        {
            case 4:
                level = 1;
                break;

            case 5:
                level = 2;
                break;

            case 6:
                level = 3;
                break;

            case 7:
                level = 4;
                break;

            case 9:
                level = 5;
                break;

            case 10:
                level = 6;
                break;

            case 11:
                level = 7;
                break;

            case 12:
                level = 8;
                break;

            case 13:
                level = 9;
                break;

            case 14:
                level = 10;
                break;

            case 15:
                level = 11;
                break;

            case 16:
                level = 12;
                break;

            case 17:
                level = 13;
                break;

            case 19:
                level = 14;
                break;

            case 21:
                level = 15;
                break;

        }

        //if (puntaje.puntos >= 20 && puntaje.puntos <= 100)
        //{
        //    stars = 1;
        //}

        //if (puntaje.puntos >= 40 && puntaje.puntos <= 300)
        //{
        //    stars = 2;
        //}

        //if (puntaje.puntos >= 500)
        //{
        //    stars = 3;
        //}

        switch (level)
        {
            case 2:
                if (puntaje.puntos >= 20 && puntaje.puntos <= 59)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 60 && puntaje.puntos <= 99)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 100)
                {
                    stars = 3;
                }
                break;


            case 3:
                if (puntaje.puntos >= 60 && puntaje.puntos <= 79)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 80 && puntaje.puntos <= 199)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 200)
                {
                    stars = 3;
                }
                break;


            case 4:
                if (puntaje.puntos >= 60 && puntaje.puntos <= 99)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 100 && puntaje.puntos <= 299)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 300)
                {
                    stars = 3;
                }
                break;


            case 5:
                if (puntaje.puntos >= 100 && puntaje.puntos <= 199)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 200 && puntaje.puntos <= 399)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 400)
                {
                    stars = 3;
                }
                break;


            case 6:
                if (puntaje.puntos >= 150 && puntaje.puntos <= 299)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 300 && puntaje.puntos <= 519)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 520)
                {
                    stars = 3;
                }
                break;


            case 7:
                if (puntaje.puntos >= 150 && puntaje.puntos <= 299)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 300 && puntaje.puntos <= 519)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 520)
                {
                    stars = 3;
                }
                break;


            case 8:
                if (puntaje.puntos >= 300 && puntaje.puntos <= 499)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 500 && puntaje.puntos <= 699)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 700)
                {
                    stars = 3;
                }
                break;


            case 9:
                if (puntaje.puntos >= 300 && puntaje.puntos <= 499)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 500 && puntaje.puntos <= 699)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 700)
                {
                    stars = 3;
                }
                break;



            case 10:

                if (puntaje.puntos >= 400 && puntaje.puntos <= 599)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 600 && puntaje.puntos <= 899)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 900)
                {
                    stars = 3;
                }
                break;



            case 11:

                if (puntaje.puntos >= 400 && puntaje.puntos <= 599)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 600 && puntaje.puntos <= 899)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 900)
                {
                    stars = 3;
                }
                break;



            case 12:

                if (puntaje.puntos >= 400 && puntaje.puntos <= 600)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 600 && puntaje.puntos <= 899)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 900)
                {
                    stars = 3;
                }
                break;




            case 13:

                if (puntaje.puntos >= 400 && puntaje.puntos <= 600)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 600 && puntaje.puntos <= 899)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 900)
                {
                    stars = 3;
                }
                break;




            case 14:

                if (puntaje.puntos >= 400 && puntaje.puntos <= 600)
                {
                    stars = 1;
                }

                if (puntaje.puntos >= 600 && puntaje.puntos <= 899)
                {
                    stars = 2;
                }
                if (puntaje.puntos >= 900)
                {
                    stars = 3;
                }
                break;
        }



        //JEFE NO HIT

        if (level == 14 && hit == 0 && PlayerPrefs.GetInt("logro7conseguido") <= 0)
        {
            Debug.LogWarning("logro 7");
            achievementObject.bossnohit();
        }


        //NIVEL NORMAL NO HIT

        if (hit <= 0 && PlayerPrefs.GetInt("logro6conseguido") <= 0)

        {

            Debug.LogWarning("logro 6");
            achievementObject.levelnohit();

        }


        //NO SHOOT

        if (shooting.shootNumber <= 0 && PlayerPrefs.GetInt("logro4conseguido") <= 0)
        {
            Debug.LogWarning("logro 4");
            achievementObject.levelnoshoot();
        }


        //HEALING 


        if (healing <= 0)

        {

            if (noHealCount <= 0 && PlayerPrefs.GetInt("logro5conseguido") <= 0)
            {

                Debug.LogWarning("logro 5");

                achievementObject.noheal();

            }

            noHealCount++;

            PlayerPrefs.SetInt("noheal", noHealCount);



            if (level >= 14 && PlayerPrefs.GetInt("noheal") >= 13 && PlayerPrefs.GetInt("logro8conseguido") <= 0)
            {
                Debug.LogWarning("logro 8");
                achievementObject.noHealGame();
            }

        }

        //complete game

        if (level >= 14 && PlayerPrefs.GetInt("logro2conseguido") <= 0)
        {
            Debug.Log("logro 2");
            achievementObject.completeGame();

        }



        AnalyticsService.Instance.CustomData("LevelComplete", DatosEndgame);


        Debug.Log("LevelComplete =" + level);
        Debug.Log("LevelComplete.stars =" + stars);
        Debug.Log("LevelComplete.healing =" + healing);
        Debug.Log("LevelComplete.hit =" + hit);
        Debug.Log("LevelComplete.basicoHit =" + basicoHit);
        Debug.Log("LevelComplete.basicoPHit =" + basicoPHit);
        Debug.Log("LevelComplete.gordoHit =" + gordoHit);
        Debug.Log("LevelComplete.gordoPHit =" + gordoPHit);
        Debug.Log("LevelComplete.rapidoHit =" + rapidoHit);
        Debug.Log("LevelComplete.rapidoPHit =" + rapidoPHit);
        Debug.Log("LevelComplete.rodeteHit =" + rodeteHit);
        Debug.Log("LevelComplete.rodetePHit =" + rodetePHit);
        Debug.Log("LevelComplete.aranaHit =" + aranaHit);
        Debug.Log("LevelComplete.cucarachaHit =" + cucarachaHit);
        Debug.Log("LevelComplete.jefeHit =" + jefeHit);

        levelstart.bossDefeated = true;






        StartCoroutine(sumarEstrellas());

    }

    IEnumerator sumarEstrellas()
    {

        if (stars == 1)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
        }
        if (stars == 2)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            star2.SetActive(true);
        }
        if (stars == 3)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }

 
    }
}
