using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endlessLose : MonoBehaviour
{



    public Text scoretext;

    public int finalScore;

    public Text timetext;

    public int finaltime;

    public Endlesstimer endlesstimer;

    public Puntaje puntaje;

    // Start is called before the first frame update
    void Start()
    {
        endlesstimer.playerAlive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (endlesstimer.playerAlive == false)
        {
            finalScore = puntaje.puntos;
            
            scoretext.text = finalScore.ToString();

            finaltime = endlesstimer.timeHours;

            timetext.text = finaltime.ToString();
        }
    }


}
