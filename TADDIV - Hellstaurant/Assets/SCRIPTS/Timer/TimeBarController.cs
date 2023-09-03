using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBarController : MonoBehaviour
{
    public Image timeBar;           // Reference to the time bar image.
    public float totalTime = 60f;   // Total time in seconds.
    private float currentTime;      // Current time left.
    private bool isTimeRunning;     // Flag to control whether the time is running.

    void Start()
    {
        currentTime = totalTime;    // Initialize current time to the total time.
        isTimeRunning = true;        // Start the timer when the scene begins.
    }

    void Update()
    {
        if (isTimeRunning)
        {
            // Update the time bar's fill amount based on the remaining time.
            timeBar.fillAmount = currentTime / totalTime;

            // Reduce the current time.
            currentTime -= Time.deltaTime;

            // Check if time has run out.
            if (currentTime <= 0f)
            {
                // Time is up, you can add game over logic here.
                Debug.Log("Time's up!");
                currentTime = 0f; // Ensure it doesn't go negative.
                isTimeRunning = false; // Stop the timer when time runs out.
            }
        }
    }
}
