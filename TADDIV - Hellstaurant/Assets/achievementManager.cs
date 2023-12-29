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
        achievements = PlayerPrefs.GetInt("achievements");


        if (PlayerPrefs.GetInt("partidasCreadas") >= 1)
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
        if (achievements >= 8) 
        {
            StartCoroutine (platinumAchievement());
        }

        achievements = PlayerPrefs.GetInt("achievements");
    }

    public void allskins()
    {
       StartCoroutine(allSkinsAchievement());
    }

    public void allpotenciadores()
    {
        StartCoroutine(allPotAchievement());
    }


    IEnumerator newGameAchievement()
    {
        popupNewGame.SetActive(true);
        achievements++;

        PlayerPrefs.SetInt("achievements", achievements);
        yield return new WaitForSeconds(3);
        popupNewGame.SetActive(false);
    }

    IEnumerator platinumAchievement()
    {
        popupPlatino.SetActive(true);
        yield return new WaitForSeconds(3);
        popupNewGame.SetActive(false);
    }

    IEnumerator allSkinsAchievement()
    {
        popupSkins.SetActive(true);
        yield return new WaitForSeconds(3);
        popupSkins.SetActive(false);
    }

    IEnumerator allPotAchievement()
    {
        popupPotenciador.SetActive(true);
        yield return new WaitForSeconds(3);
        popupPotenciador.SetActive(false);
    }


}
