using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Cinemachine.DocumentationSortingAttribute;

public class achievementManager : MonoBehaviour
{
    static achievementManager variable;


    public static int achievements;

    public static int logro1;
    public static int logro2;
    public static int logro3;
    public static int logro4;
    public static int logro5;
    public static int logro6;
    public static int logro7;
    public static int logro8;
    public static int logro9;
    public static int platino;


    [Header("VARIABLES LOGROS")]

    public GameObject popupNewGame;
    public GameObject popupPlatino;
    public GameObject popupSkins;
    public GameObject popupPotenciador;
    public GameObject popupBossNoHit;
    public GameObject popupLevelNoHit;
    public GameObject popupLevelNoShoot;
    public GameObject popupNoHeal;
    public GameObject popupMoney;
    public GameObject popupEndless;
    public GameObject popupNoHealGame;
    public GameObject popupCompleteGame;

    Dictionary<string, object> DatosLogros = new Dictionary<string, object>()
{
           {"logrosTotales", achievements},
           {"logro1", logro1 },
           {"logro2", logro2 },
           {"logro3", logro3 },
           {"logro4",logro4},
           {"logro5", logro5 },
           {"logro6", logro6 },
           {"logro7", logro7 },
           {"logro8", logro8 },
           {"logro9", logro9 },
           {"platino", platino},

};
    void Awake()
    {
        if (variable != null)
        {
           Destroy(this.gameObject);
        }

        else
        {
            variable = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        logro1 = PlayerPrefs.GetInt("logro1conseguido");
        logro2 = PlayerPrefs.GetInt("logro2conseguido");
        logro3 = PlayerPrefs.GetInt("logro3conseguido");
        logro4 = PlayerPrefs.GetInt("logro4conseguido");
        logro5 = PlayerPrefs.GetInt("logro5conseguido");
        logro6 = PlayerPrefs.GetInt("logro6conseguido");
        logro7 = PlayerPrefs.GetInt("logro7conseguido");
        logro8 = PlayerPrefs.GetInt("logro8conseguido");
        logro9 = PlayerPrefs.GetInt("logro9conseguido");
        platino = PlayerPrefs.GetInt("platinoconseguido");


        achievements = PlayerPrefs.GetInt("achievements");


        //if (PlayerPrefs.GetInt("partidasCreadas") == 1)
        //{
        //    if (popupNewGame != null)
        //    {
        //        StartCoroutine(newGameAchievement());
        //    }
        //}


        if (SceneManager.GetActiveScene().buildIndex == 23)
        {
            newGame();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (achievements == 9) 
        {
            StartCoroutine (platinumAchievement());
        }

        achievements = PlayerPrefs.GetInt("achievements");
    }


    public void newGame()
    {
        StartCoroutine(newGameAchievement());
    }

    public void bossnohit()
    {
        StartCoroutine(bossNoHitAchievement());
    }

    public void levelnohit()
    {
        StartCoroutine(levelNoHitAchievement());
    }

    public void levelnoshoot()
    {
        StartCoroutine(levelNoShootAchievement());
    }

    public void noheal()
    {
        StartCoroutine(noHealAchievement());
    }

    public void money()
    {
        StartCoroutine(moneyAchievement());
    }


    public void endless()
    {
        StartCoroutine(endlessAchievement());
    }

    public void noHealGame()
    {
        StartCoroutine(noHealGameAchievement());
    }

    public void completeGame()
    {
        StartCoroutine(completeGameAchievement());
    }




    IEnumerator newGameAchievement()
    {
        popupNewGame.SetActive(true);
        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro1conseguido", 1);

        yield return new WaitForSeconds(3);
        popupNewGame.SetActive(false);


        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator platinumAchievement()
    {
        popupPlatino.SetActive(true);
        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("platinoconseguido", 1);

        yield return new WaitForSeconds(3);

        popupPlatino.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }
    IEnumerator bossNoHitAchievement()
    {
        popupBossNoHit.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro7conseguido", 1);

        yield return new WaitForSeconds(3);
        popupBossNoHit.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator levelNoHitAchievement()
    {
        popupLevelNoHit.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);


        PlayerPrefs.SetInt("logro6conseguido", 1);

        yield return new WaitForSeconds(3);
        popupLevelNoHit.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator levelNoShootAchievement()
    {
        popupLevelNoShoot.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro4conseguido", 1);

        yield return new WaitForSeconds(3);
        popupLevelNoShoot.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }


    IEnumerator noHealAchievement()
    {
        popupNoHeal.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro5conseguido", 1);

        yield return new WaitForSeconds(3);
        popupNoHeal.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator moneyAchievement()
    {
        popupMoney.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro3conseguido", 1);

        yield return new WaitForSeconds(3);
        popupMoney.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator endlessAchievement()
    {
        popupEndless.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro9conseguido", 1);

        yield return new WaitForSeconds(3);
        popupEndless.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator noHealGameAchievement()
    {
        popupNoHealGame.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro8conseguido", 1);

        yield return new WaitForSeconds(3);
        popupNoHealGame.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }

    IEnumerator completeGameAchievement()
    {
        popupCompleteGame.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro2conseguido", 1);

        yield return new WaitForSeconds(3);
        popupCompleteGame.SetActive(false);

        AnalyticsService.Instance.CustomData("Achievements", DatosLogros);
    }



}
