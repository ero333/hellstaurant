using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 150;
    public BossHealthBar BossHealth;
    public Puntaje puntajescript;

    public fireBullets fireBullets;

    public BulletSpawner spawner;

    public GameObject spiralShoot;


    public float tiempoEntreAcciones = 5f;

  

    void Start()
    {
        Hitpoints = MaxHitpoints;
        BossHealth.BossSetHealth(Hitpoints, MaxHitpoints);

        StartCoroutine(randomAttack());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other) // Cuando colisionan la pizza y el enemigo
    {
        if (other.CompareTag("PizzaShoot")) // Si la pizza tiene el tag PizzaShoot
        {
            Hitpoints--; // Le baja 1 de vida al enemigo

            BossHealth.reducelife(Hitpoints);

            puntajescript.obtenerPuntaje(20);

            Destroy(other.gameObject); // Destruye la pizza que le peg�

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("FugazzettaShoot")) // Si la pizza tiene el tag FugazzettaShoot
        {
            Hitpoints = Hitpoints - 2; // Le baja 2 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("FainaShoot")) // Si la pizza tiene el tag FainaShoot
        {
            Hitpoints = Hitpoints - 1; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("PicanteShoot")) // Si la pizza tiene el tag FainaShoot
        {
            Hitpoints = Hitpoints - 3; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("CajaShoot")) // Si la pizza tiene el tag CajaShoot
        {
            Hitpoints = Hitpoints - 5; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }
    }


    public void onDeath()
    {
        Destroy(gameObject);
    }


    IEnumerator randomAttack()
    {
        while (true) 
        {
            
            int opcion = Random.Range(0, 2); 

            // Ejecuta la acción elegida
            if (opcion == 0)
            {
               fireBullets.Fire();
            }
            else
            {
                spiralShoot.SetActive(true);
                yield return new WaitForSeconds(1f);
                spiralShoot.SetActive(false);
            }

            
            yield return new WaitForSeconds(tiempoEntreAcciones);
        }
    }

}
