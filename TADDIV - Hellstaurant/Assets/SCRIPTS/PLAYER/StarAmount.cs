using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
       StartCoroutine(sumarEstrellas()); 

       Debug.Log("GameOver.healing =" + healthController.healingTimes);
       Debug.Log("GameOver.hit =" + healthController.hit);
       Debug.Log("GameOver.basicoHit =" + healthController.basicoHit);
       Debug.Log("GameOver.basicoPHit =" + healthController.basicoPHit);
       Debug.Log("GameOver.gordoHit =" + healthController.gordoHit);
       Debug.Log("GameOver.gordoPHit =" + healthController.gordoPHit);
       Debug.Log("GameOver.rapidoHit =" + healthController.rapidoHit);
       Debug.Log("GameOver.rapidoPHit =" + healthController.rapidoPHit);
       Debug.Log("GameOver.rodeteHit =" + healthController.rodeteHit);
       Debug.Log("GameOver.rodetePHit =" + healthController.rodetePHit);
       Debug.Log("GameOver.arañaHit =" + healthController.arañaHit);
       Debug.Log("GameOver.cucarachaHit =" + healthController.cucarachaHit);
       Debug.Log("GameOver.jefeHit =" + healthController.bossHit);

       if (PlayerPrefs.GetInt("NivelActual") == 4)
            {
             lastlevel = 1;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 5)
            {
             lastlevel = 2;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 6)
            {
             lastlevel = 3;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 7)
            {
             lastlevel = 4;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 9)
            {
             lastlevel = 5;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 10)
            {
             lastlevel = 6;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 11)
            {
             lastlevel = 7;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 12)
            {
             lastlevel = 8;
            }
       if (PlayerPrefs.GetInt("NivelActual") == 13)
           {
            lastlevel = 9;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 14)
           {
            lastlevel = 10;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 15)
           {
            lastlevel = 11;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 16)
           {
            lastlevel = 12;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 17)
           {
            lastlevel = 13;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 18)
           {
            lastlevel = 14;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 20)
           {
            lastlevel = 15;
           }
       if (PlayerPrefs.GetInt("NivelActual") == 22)
           {
            lastlevel = 16;
           }

    Debug.Log("LevelComplete =" + level);

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

        levelstart.bossdefeated = true;
    }
}
