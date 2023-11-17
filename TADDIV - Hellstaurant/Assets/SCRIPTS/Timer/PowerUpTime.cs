using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpTime : MonoBehaviour
{
    public Image barra;          
    public float tiempoDePotenciador = 10f;   
    public float tiempoActual;      
    public bool tiempoEnMarcha;

    public PlayerShooting playershoot;

    public PowerUpTime Instance;

    public PotenciadorUIController UIcontrol;

    public void Awake()
    {
        Instance = this; 
    }
    void Start()
    {
        tiempoActual = tiempoDePotenciador;   
        tiempoEnMarcha = true;       
    }

    void Update()
    {
        if (tiempoEnMarcha)
        {
            
            barra.fillAmount = tiempoActual / tiempoDePotenciador;

            
            tiempoActual -= Time.deltaTime;

            
            if (tiempoActual <= 0f)
            {
                
                deactivateAll();
                tiempoActual = 0f; 
                tiempoEnMarcha = false; 
            }
        }
    }

    public void resetClock()
    {

        tiempoEnMarcha = true;

        tiempoActual = tiempoDePotenciador;

        barra.fillAmount = tiempoActual / tiempoDePotenciador;

        if (tiempoActual <= 0f)
        {

            deactivateAll();
            tiempoActual = 0f;
            tiempoEnMarcha = false;
        }
    }

    public void deactivateAll()
    {

        
        playershoot.Faina = false;
        playershoot.Picante = false;
        playershoot.Caja = false;
        playershoot.Fugazzetta = false;

        playershoot.anim.runtimeAnimatorController = playershoot.normal as RuntimeAnimatorController;

        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Potenciador"), false);

        playershoot.isInvincible = false;

        // Restaurar velocidad normal del jugador inmediatamente
        playershoot.playerMovement.speed = 4f; // Cambia velocidad


        UIcontrol.Salida();


    }


}

