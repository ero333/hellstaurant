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
    

       if (PlayerPrefs.GetInt("NivelActual") == 4)
            {
             level = 1;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 5)
            {
             level = 2;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 6)
            {
             level = 3;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 7)
            {
             level = 4;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 9)
            {
             level = 5;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 10)
            {
             level = 6;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 11)
            {
             level = 7;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 12)
            {
             level = 8;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 13)
           {
            level = 9;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 14)
           {
            level = 10;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 15)
           {
            level = 11;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 16)
           {
            level = 12;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 17)
           {
            level = 13;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 18)
           {
            level = 14;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 20)
           {
            level = 15;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 22)
           {
            level = 16;
           }

        Debug.Log("LevelComplete =" + level);

        StartCoroutine(sumarEstrellas());

    }

    IEnumerator sumarEstrellas()
    {


        if (puntaje.puntos >= 20 && puntaje.puntos <= 100)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive (true);
            stars = 1;
        }

        if (puntaje.puntos >= 40 && puntaje.puntos <= 300)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            yield return new WaitForSeconds(1f);
            star2.SetActive(true);
            stars = 2;
        }

        if (puntaje.puntos >= 500)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            yield return new WaitForSeconds(1f);
            star2.SetActive(true);
            yield return new WaitForSeconds(1f);
            star3.SetActive(true);
            stars = 3;
        }

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

    }
}
