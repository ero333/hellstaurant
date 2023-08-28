using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBasicDamage : MonoBehaviour
{

    public float enemyLife; // Variable de la vida del enemigo

    public int puntosEnemigo;

    public GameObject contadorPuntos;

    public Puntaje puntaje;

    

    void Start()
    {
        contadorPuntos = GameObject.FindGameObjectWithTag("Score");
        puntaje = contadorPuntos.GetComponent<Puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other) // Cuando colisionan la pizza y el enemigo
    {
        if (other.CompareTag("PizzaShoot")) //Si la pizza tiene el tag PizzaShoot
        {
            enemyLife--; //Le baja 1 de vida al enemigo
            Destroy(other.gameObject); //Destruye la pizza que le pegó

            if (enemyLife <= 0) 
            {
                onDeath();
            }
        }

    }

    public void onDeath()
    {
        puntaje.obtenerPuntaje(puntosEnemigo);
        Destroy(gameObject); //Cuando la vida es menor o igual a cero se destruye el enemigo
    }
}
