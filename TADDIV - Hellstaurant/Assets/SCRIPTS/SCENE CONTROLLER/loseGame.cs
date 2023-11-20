using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine.Analytics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loseGame : MonoBehaviour
{

    public string tagEnemy = "Enemy";

    public GameObject player;

    public EnemySpawner spawner;
    public EnemySpawner spawner2;
    public EnemySpawner spawner3;

    public AudioSource loseSound;

    public GameObject bulletSpawner;

    [SerializeField] private GameObject winscreen;

    public GameObject enemiespawner;

    public GameObject potenciadoresspawner;

    [SerializeField] private GameObject deathdebug;

    public GameObject botonRestart;

    public GameObject botonOmitir;



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
    public static long timer;
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




    // Start is called before the first frame update
    void Start()
    {
        winscreen = GameObject.FindGameObjectWithTag("winscreen"); 

        deathdebug = GameObject.FindGameObjectWithTag("debugDeath");


        loseSound = GameObject.FindGameObjectWithTag("sonidolose").GetComponent<AudioSource>();

        EventSystem.current.SetSelectedGameObject(botonRestart.GetComponentInChildren<Button>().gameObject);


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



        AnalyticsService.Instance.CustomData("LoseGame", DatosGameover);


        Debug.Log("LoseGame.enemy =" + enemy);
        Debug.Log("LoseGame.healing =" + healing);
        Debug.Log("LoseGame.hit =" + hit);
        Debug.Log("LoseGame.basicoHit =" + basicoHit);
        Debug.Log("LoseGame.basicoPHit =" + basicoPHit);
        Debug.Log("LoseGame.gordoHit =" + gordoHit);
        Debug.Log("LoseGame.gordoPHit =" + gordoPHit);
        Debug.Log("LoseGame.rapidoHit =" + rapidoHit);
        Debug.Log("LoseGame.rapidoPHit =" + rapidoPHit);
        Debug.Log("LoseGame.rodeteHit =" + rodeteHit);
        Debug.Log("LoseGame.rodetePHit =" + rodetePHit);
        Debug.Log("LoseGame.aranaHit =" + aranaHit);
        Debug.Log("LoseGame.cucarachaHit =" + cucarachaHit);
        Debug.Log("LoseGame.jefeHit =" + jefeHit);

        Debug.Log("LoseGame.time = " + timer);
        Debug.Log("LoseGame.level = " + level);




    }
    // Update is called once per frame
    void Update()
    {
        if (winscreen != null)
        {
            winscreen.SetActive(false);
        }

    }

    public void OnEnable()
    {

       //deathdebug.SetActive(true);

      StartCoroutine(loseProcess());

    }

    public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }


    IEnumerator loseProcess()
    {
        if (loseSound != null)
        {

            loseSound.Play();
        }
        

        if (botonOmitir != null)
        {
            botonOmitir.SetActive(false);
        }

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }

        if (spawner != null)
        {

            spawner.StopAllCoroutines();

            spawner.deleteClones();

        }

        enemiespawner.SetActive(false);

        if (potenciadoresspawner != null)
        {
            potenciadoresspawner.SetActive(false);
        }


        yield return new WaitForSeconds(0.6f);

        player.SetActive(false);

        if (bulletSpawner != null)
        {
            bulletSpawner.SetActive(false);
        }

    }
}
