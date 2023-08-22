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

    
    public GameObject WIN;


    // Start is called before the first frame update
    void Start()
    {
        timeHours = startingTime;
        StartCoroutine(routine:advanceHourOverTime());



        
    }

    // Update is called once per frame
    private void Update()
    {
        timeText.text = timeHours + ":00 PM";
        

    }

    private IEnumerator advanceHourOverTime()
    {
        yield return new WaitForSeconds(TimeUntilHourChange);

        if (timeHours == 12)
            timeHours = 1;
        else
            timeHours++;

        if (timeHours < timeLimit)
            StartCoroutine(routine:advanceHourOverTime());

        if (timeHours == 8)
           WIN.gameObject.SetActive(true);
           
             
    }

    
}
