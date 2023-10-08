using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endlesstimer : MonoBehaviour
{
    [SerializeField] private int startingTime;
    [SerializeField] private float TimeUntilHourChange;
    [SerializeField] private TMP_Text timeText;

    [NonSerialized] public int timeHours;

    public bool playerAlive;

    public GameObject WIN;
    private Animator WinAnimator;


    // Start is called before the first frame update
    void Start()
    {
        playerAlive = true;
        timeHours = startingTime;


        StartCoroutine(routine: advanceHourOverTime());




    }

    // Update is called once per frame
    private void Update()
    {
        timeText.text = " " + timeHours;


    }

    private IEnumerator advanceHourOverTime()
    {
        if (playerAlive)
        {
            yield return new WaitForSeconds(TimeUntilHourChange);

                timeHours++;

          
           StartCoroutine(routine: advanceHourOverTime());



        }
        // else
        // {
        //   stopTimer();
        //}

    }

    public void stopTimer()
    {
        if (!playerAlive)
        {
            StopAllCoroutines();
            timeText.text = " " + timeHours;
        }
    }


}