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

    public PlayerHealthController healthController;

    public int stars;

    public int level;

    public bool bossDefeated = false;

    public levelStart levelstart;

    public int lastlevel;



    // Start is called before the first frame update
    void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
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

        if (puntaje.puntos >= 20 && puntaje.puntos <= 100)
        {
            stars = 1;
        }

        if (puntaje.puntos >= 40 && puntaje.puntos <= 300)
        {
            stars = 2;
        }

        if (puntaje.puntos >= 500)
        {
            stars = 3;
        }

        Debug.Log("LevelComplete =" + level);
        Debug.Log("LevelComplete.stars =" + stars);
        Debug.Log("LevelComplete.healing =" + healthController.healingTimes);
        Debug.Log("LevelComplete.hit =" + healthController.hit);
        Debug.Log("LevelComplete.basicoHit =" + healthController.basicoHit);
        Debug.Log("LevelComplete.basicoPHit =" + healthController.basicoPHit);
        Debug.Log("LevelComplete.gordoHit =" + healthController.gordoHit);
        Debug.Log("LevelComplete.gordoPHit =" + healthController.gordoPHit);
        Debug.Log("LevelComplete.rapidoHit =" + healthController.rapidoHit);
        Debug.Log("LevelComplete.rapidoPHit =" + healthController.rapidoPHit);
        Debug.Log("LevelComplete.rodeteHit =" + healthController.rodeteHit);
        Debug.Log("LevelComplete.rodetePHit =" + healthController.rodetePHit);
        Debug.Log("LevelComplete.arañaHit =" + healthController.arañaHit);
        Debug.Log("LevelComplete.cucarachaHit =" + healthController.cucarachaHit);
        Debug.Log("LevelComplete.jefeHit =" + healthController.bossHit);

        levelstart.bossDefeated = true;

        AnalyticsService.Instance.CustomData("LevelComplete", new Dictionary<string, object>
        {
           {"level", level },
           {"stars", stars},
           {"healing", healthController.healingTimes},
           {"hit", healthController.hit},
           {"basicoHit", healthController.basicoHit},
           {"basicoPHit", healthController.basicoPHit},
           {"gordoHit", healthController.gordoHit},
           {"gordoPHit", healthController.gordoPHit},
           {"rapidoHit", healthController.rapidoHit},
           {"rapidoPHit", healthController.rapidoPHit},
           {"rodeteHit", healthController.rodeteHit},
           {"rodetePHit", healthController.rodetePHit},
           {"arañaHit", healthController.arañaHit},
           {"cucarachaHit", healthController.cucarachaHit},
           {"jefeHit", healthController.bossHit}

        });


        StartCoroutine(sumarEstrellas());

    }

    IEnumerator sumarEstrellas()
    {


        if (puntaje.puntos >= 20 && puntaje.puntos <= 100)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive (true);
        }

        if (puntaje.puntos >= 40 && puntaje.puntos <= 300)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            yield return new WaitForSeconds(1f);
            star2.SetActive(true);
        }

        if (puntaje.puntos >= 500)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            yield return new WaitForSeconds(1f);
            star2.SetActive(true);
            yield return new WaitForSeconds(1f);
            star3.SetActive(true);
        }

   

    }
}
