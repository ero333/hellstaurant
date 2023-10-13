using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletLife = 1f;  // Cuanto tiempo pasa hasta que se destruya la bala
    public float rotation = 0f;
    public float speed = 1f;
    public int damageAmount = 1; // Daño que inflige la bala al jugador

    private Vector2 spawnPoint;
    private float timer = 0f;

    public Puntaje puntaje;

    void Start()
    {
        puntaje = GameObject.FindGameObjectWithTag("Score").GetComponent<Puntaje>();
        spawnPoint = new Vector2(transform.position.x, transform.position.y);
    }

    void Update()
    {
        if (timer > bulletLife) Destroy(this.gameObject);
        timer += Time.deltaTime;
        transform.position = Movement(timer);
    }

    private Vector2 Movement(float timer)
    {
        float x = timer * speed * transform.right.x;
        float y = timer * speed * transform.right.y;
        return new Vector2(x + spawnPoint.x, y + spawnPoint.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
    {
        // Verifica si el objeto colisionado tiene el componente PlayerHealthController
        PlayerHealthController playerHealthController = other.GetComponent<PlayerHealthController>();
        if (playerHealthController != null && playerHealthController.invincibleLength <= 0)
        {
            playerHealthController.TakeDamage(damageAmount);



                playerHealthController.lastAttackingEnemy = "JEFE";

                playerHealthController.bossHit++;
                playerHealthController.hit++;

                if (puntaje.puntos >= 10)
                {
                    puntaje.puntos = puntaje.puntos - 10;
                }
            }

        Destroy(this.gameObject); // destruye la bala al colisionar con el jugador
    }
    }
}

