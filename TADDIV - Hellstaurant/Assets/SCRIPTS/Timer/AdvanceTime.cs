using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdvanceTime : MonoBehaviour
{
    [SerializeField] private int startingTime;
    [SerializeField] private float TimeUntilHourChange;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int timeLimit;

    [NonSerialized] public int timeHours;

    public bool playerAlive;

    public GameObject WIN;
    private Animator WinAnimator;


    // Start is called before the first frame update
    void Start()
    {
        playerAlive = true;
        timeHours = startingTime;
        
        
        StartCoroutine(routine:advanceHourOverTime());



        
    }

    // Update is called once per frame
    private void Update()
    {
        timeText.text = timeHours + ":00 PM";

        if (!playerAlive)
        {
            stopTimer();
        }

    }

    private IEnumerator advanceHourOverTime()
    {
        if (playerAlive)
        {
            yield return new WaitForSeconds(TimeUntilHourChange);

            if (timeHours == 12)
                timeHours = 1;
            else
                timeHours++;

            if (timeHours < timeLimit)
                StartCoroutine(routine: advanceHourOverTime());

            if (timeHours >= 8)

                WIN.gameObject.SetActive(true);

        }
        else
        {
            stopTimer();
        }

    }

    public void stopTimer()
    {
        if (!playerAlive)
        {   
            StopAllCoroutines();
             timeText.text = timeHours + ":00 PM";
        }
    }


}
