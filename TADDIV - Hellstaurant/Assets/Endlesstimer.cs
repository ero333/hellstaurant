using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem.LowLevel;
using Unity.VisualScripting;

public class Endlesstimer : MonoBehaviour
{
    [SerializeField] private int startingTime;
    [SerializeField] private float TimeUntilHourChange;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int timeLimit;

    [NonSerialized] public int timeHours;

    public bool playerAlive;

    public GameObject WIN;
    private Animator WinAnimator;

    public static Endlesstimer instance;


    public EnemySpawner enemyspawner;

    public float spawnRates;

    public achievementManager achievementobject;



    public void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

        achievementobject=GameObject.FindGameObjectWithTag ("achievementManager").GetComponent<achievementManager> ();

        playerAlive = true;
        timeHours = startingTime;

        enemyspawner.spawnRate = 15f;

        StartCoroutine(routine: advanceHourOverTime());

        StartCoroutine (riseDifficulty());


    }

    // Update is called once per frame
    private void Update()
    {
        timeText.text = timeHours.ToString();

        if (timeHours >= 90 && playerAlive && PlayerPrefs.GetInt("logro9conseguido") == 0)
        {
            achievementobject.endless();
        }

    }

    private IEnumerator advanceHourOverTime()
    {
        if (playerAlive)
        {
            yield return new WaitForSeconds(TimeUntilHourChange);

                timeHours++;

            
                StartCoroutine(routine: advanceHourOverTime());


        if (!playerAlive)
            {
                stopTimer();
            }
            

            

        }
    }

    public void stopTimer()
    {
        if (!playerAlive)
        {
            StopAllCoroutines();
            timeText.text = timeHours.ToString();
        }
    }

    IEnumerator riseDifficulty()
    {
        yield return new WaitForSeconds(30f);


        GameObject[] spawners = GameObject.FindGameObjectsWithTag("spawners");

        foreach (GameObject obj in spawners)
        {
            EnemySpawner script = obj.GetComponent<EnemySpawner>();
            if (script != null)
            {
                script.spawnRate = script.spawnRate -1;
            }
        }

        enemyspawner.spawnRate = enemyspawner.spawnRate - 1f;

        StartCoroutine (routine: riseDifficulty());

    }


}