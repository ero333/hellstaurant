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
    [Range(0, 100)] public float chanceToDrop; // enemigo dropea monedas
    public GameObject collectible; // lo que vamos a dropear

    public int amountToDrop; // Cantidad de monedas a dropear

    void Start()
    {
        contadorPuntos = GameObject.FindGameObjectWithTag("Score");
        puntaje = contadorPuntos.GetComponent<Puntaje>();
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other) // Cuando colisionan la pizza y el enemigo
    {
        if (other.CompareTag("PizzaShoot")) // Si la pizza tiene el tag PizzaShoot
        {
            enemyLife--; // Le baja 1 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le pegó

            if (enemyLife <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("FugazzettaShoot")) // Si la pizza tiene el tag PizzaShoot
        {
            enemyLife = enemyLife -2; // Le baja 2 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le pegó

            if (enemyLife <= 0)
            {
                onDeath();
            }
        }
    }

    public void onDeath()
    {
        puntaje.obtenerPuntaje(puntosEnemigo);
        Destroy(gameObject); // Cuando la vida es menor o igual a cero se destruye el enemigo

        float dropSelect = Random.Range(0, 100f);

        if (dropSelect <= chanceToDrop) 
        {
            for (int i = 0; i < amountToDrop; i++) //para drop mas de una moneda que no queden encimadas 
            {
                float xOffset = (i - (amountToDrop - 1) * 0.5f) * 0.5f;
                Instantiate(collectible, transform.position + new Vector3(xOffset, 0, 0), Quaternion.identity);
            }
        }
    }
}
