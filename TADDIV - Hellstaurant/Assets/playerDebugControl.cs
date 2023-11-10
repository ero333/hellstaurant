using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.Analytics;
using static Cinemachine.DocumentationSortingAttribute;

public class playerDebugControl : MonoBehaviour
{

    public levelStart levelStart;

    public PlayerHealthController healthController;



    [Header("variables diccionario")]


    public static int level;
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
    public static long  timer;
    public static string enemy;



    Dictionary<string, object> DatosGameover = new Dictionary<string, object>()
{

           {"enemy", enemy },
           {"level", level },
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
           {"jefeHit", jefeHit},
           {"time", timer}
};






    //public void Start()
    //{

    //}
    // Start is called before the first frame update
    public void Start()
    {

        levelStart = GameObject.FindGameObjectWithTag("Player").GetComponent<levelStart>();

        healthController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealthController>();

        timer = levelStart.leveltimer;
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
        enemy = healthController.lastAttackingEnemy;




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


        AnalyticsService.Instance.CustomData("LevelComplete", DatosGameover);


        Debug.Log("GameOver.enemy =" + enemy);
        Debug.Log("GameOver.healing =" + healing);
        Debug.Log("GameOver.hit =" + hit);
        Debug.Log("GameOver.basicoHit =" + basicoHit);
        Debug.Log("GameOver.basicoPHit =" + basicoPHit);
        Debug.Log("GameOver.gordoHit =" + gordoHit);
        Debug.Log("GameOver.gordoPHit =" + gordoPHit);
        Debug.Log("GameOver.rapidoHit =" + rapidoHit);
        Debug.Log("GameOver.rapidoPHit =" + rapidoPHit);
        Debug.Log("GameOver.rodeteHit =" + rodeteHit);
        Debug.Log("GameOver.rodetePHit =" + rodetePHit);
        Debug.Log("GameOver.aranaHit =" + aranaHit);
        Debug.Log("GameOver.cucarachaHit =" + cucarachaHit);
        Debug.Log("GameOver.jefeHit =" + jefeHit);

        Debug.Log("GameOver.time = " + timer);
        Debug.Log("GameOver.level = " + level);




    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
