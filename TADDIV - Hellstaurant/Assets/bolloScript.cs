using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolloScript : MonoBehaviour
{

    private Vector2 MoveDirection;

    public int damageAmount;

    public float moveSpeed;

    public Puntaje puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = GameObject.FindGameObjectWithTag("Score").GetComponent<Puntaje>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveDirection * moveSpeed * Time.deltaTime);
    }

    public void OnEnable()
    {
        Invoke("Destroy", 3f);
    }

    public void setMoveDirection(Vector2 dir)
    {
        MoveDirection = dir;
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }

    public void OnDisable()
    {
        
        CancelInvoke();
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Verifica si el objeto colisionado tiene el componente PlayerHealthController
            PlayerHealthController playerHealthController = other.GetComponent<PlayerHealthController>();



            if (playerHealthController != null)

            {

                playerHealthController.lastAttackingEnemy = "JEFE";

                playerHealthController.bossHit++;
                playerHealthController.hit++;

                if (puntaje.puntos >= 10)
                {
                    puntaje.puntos = puntaje.puntos - 10;
                }
                playerHealthController.TakeDamage(damageAmount);
            }

            Destroy(this.gameObject); // destruye la bala al colisionar con el jugador
        }
    }
}
