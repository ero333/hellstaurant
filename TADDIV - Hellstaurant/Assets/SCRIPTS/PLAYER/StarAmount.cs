using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarAmount : MonoBehaviour
{
    public Puntaje puntaje;
    public GameObject star1, star2, star3;

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
    }

    IEnumerator sumarEstrellas()
    {
        if (puntaje.puntos >= 20 && puntaje.puntos <= 39)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive (true);
        }

        if (puntaje.puntos >= 40 && puntaje.puntos <= 59)
        {
            yield return new WaitForSeconds(1f);
            star1.SetActive(true);
            yield return new WaitForSeconds(1f);
            star2.SetActive(true);
        }

        if (puntaje.puntos >= 60)
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
