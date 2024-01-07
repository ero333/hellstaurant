using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievementManager : MonoBehaviour
{
    static achievementManager variable;


    public int achievements; 


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


    void Awake()
    {
        //if (variable != null)
        //{
        //    Destroy(this.gameObject);
        //}

        //else
        //{
        //    variable = this;
        //    DontDestroyOnLoad(this.gameObject);
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        achievements = PlayerPrefs.GetInt("achievements");


        if (PlayerPrefs.GetInt("partidasCreadas") == 1)
        {
            if (popupNewGame != null)
            {
                StartCoroutine(newGameAchievement());
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (achievements >= 9) 
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
    }

    IEnumerator platinumAchievement()
    {
        popupPlatino.SetActive(true);

        PlayerPrefs.SetInt("platinoconseguido", 1);

        yield return new WaitForSeconds(3);
        popupNewGame.SetActive(false);
    }
    IEnumerator bossNoHitAchievement()
    {
        popupBossNoHit.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro7conseguido", 1);

        yield return new WaitForSeconds(3);
        popupBossNoHit.SetActive(false);
    }

    IEnumerator levelNoHitAchievement()
    {
        popupLevelNoHit.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);


        PlayerPrefs.SetInt("logro6conseguido", 1);

        yield return new WaitForSeconds(3);
        popupLevelNoHit.SetActive(false);
    }

    IEnumerator levelNoShootAchievement()
    {
        popupLevelNoShoot.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro4conseguido", 1);

        yield return new WaitForSeconds(3);
        popupLevelNoShoot.SetActive(false);
    }


    IEnumerator noHealAchievement()
    {
        popupNoHeal.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro5conseguido", 1);

        yield return new WaitForSeconds(3);
        popupNoHeal.SetActive(false);
    }

    IEnumerator moneyAchievement()
    {
        popupMoney.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro3conseguido", 1);

        yield return new WaitForSeconds(3);
        popupMoney.SetActive(false);
    }

    IEnumerator endlessAchievement()
    {
        popupEndless.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro9conseguido", 1);

        yield return new WaitForSeconds(3);
        popupEndless.SetActive(false);
    }

    IEnumerator noHealGameAchievement()
    {
        popupNoHealGame.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro8conseguido", 1);

        yield return new WaitForSeconds(3);
        popupNoHealGame.SetActive(false);
    }

    IEnumerator completeGameAchievement()
    {
        popupCompleteGame.SetActive(true);

        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);

        PlayerPrefs.SetInt("logro2conseguido", 1);

        yield return new WaitForSeconds(3);
        popupCompleteGame.SetActive(false);
    }



}
