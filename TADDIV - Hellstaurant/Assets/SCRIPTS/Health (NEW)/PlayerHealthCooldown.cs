using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealthCooldown : MonoBehaviour
{
    public float healingCooldown = 10.0f;
    public float currentTime;
    public bool timeRunning;
    public PlayerHealthController playerHealthController;
    public PlayerHealthCooldown instance;

    public Image cooldownBar; // Asigna aquí la imagen de la barra de cooldown desde el inspector

    private void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        currentTime = 10f;
        timeRunning = false;
    }
    void Update()
    {
       if (timeRunning) 
        {
            cooldownBar.fillAmount = currentTime / healingCooldown;
            currentTime += Time.deltaTime;

            if (currentTime >= 10f)
            {
                currentTime = 10f;
                timeRunning = false;
            }
        }
    }

    public void Reset()
    {
        currentTime = 0f;
        timeRunning = true;
        cooldownBar.fillAmount = currentTime / healingCooldown;
      
        if (currentTime >= 10f)
        {
            currentTime = 10f;
            timeRunning = false;
        }
    }
}
