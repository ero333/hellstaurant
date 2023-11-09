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

    public GameObject winscreen;

    public Animator animator;


    public Transform player;

    public float tiempoEntreAcciones = 5f;

    public GameObject singleBullet;

    public float singleBulletSpeed = 5f;


    public GameObject bichosSpawn;

    public AudioSource eructosound;

    public AudioSource hitjefe;


    public float KBPower = 100;
    public float KBDuration = 2;

    public PlayerHealthController playerhealthcontroller;


    void Start()
    {
        animator = GetComponent<Animator>();
        Hitpoints = MaxHitpoints;
        BossHealth.BossSetHealth(Hitpoints, MaxHitpoints);

        hitjefe = GameObject.FindGameObjectWithTag("sonidohitenemigo").GetComponent<AudioSource>();

        eructosound = GameObject.FindGameObjectWithTag("sonidoeructo").GetComponent<AudioSource>();

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
            hitjefe.Play();

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
            hitjefe.Play();

            Hitpoints = Hitpoints - 2; // Le baja 2 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            BossHealth.reducelife(Hitpoints);

            puntajescript.obtenerPuntaje(20);

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("FainaShoot")) // Si la pizza tiene el tag FainaShoot
        {
            hitjefe.Play();

            Hitpoints = Hitpoints - 1; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            BossHealth.reducelife(Hitpoints);

            puntajescript.obtenerPuntaje(20);

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("PicanteShoot")) // Si la pizza tiene el tag FainaShoot
        {
            hitjefe.Play();

            Hitpoints = Hitpoints - 3; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            BossHealth.reducelife(Hitpoints);

            puntajescript.obtenerPuntaje(20);

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.CompareTag("CajaShoot")) // Si la pizza tiene el tag CajaShoot
        {
            hitjefe.Play();

            Hitpoints = Hitpoints - 5; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�

            BossHealth.reducelife(Hitpoints);

            puntajescript.obtenerPuntaje(20);

            if (Hitpoints <= 0)
            {
                onDeath();
            }
        }

        if (other.gameObject.tag == "Player" && !playerhealthcontroller.isHealing)
        {
            StartCoroutine(playerhealthcontroller.knockback(KBDuration, KBPower, this.transform));
        }
    }


    public void onDeath()
    {
        Destroy(gameObject);
        winscreen.SetActive(true);

    }


    IEnumerator randomAttack()
    {
        while (true) 
        {
            
            int opcion = Random.Range(0, 4); 

            // Ejecuta la acción elegida
            if (opcion == 0)
            {
                animator.SetBool("attacking", true);
                eructosound.Play();
                fireBullets.Fire();
                yield return new WaitForSeconds(1f);
                    animator.SetBool("attacking", false); 
            }

            if(opcion == 1)
            {
                animator.SetBool("attacking", true);
                eructosound.Play();
                // Código para la segunda acción
                Debug.Log("Ejecutando Acción 2");

                // Obtener la dirección hacia el jugador
                Vector3 direccion = (player.position - transform.position).normalized;

                // Instanciar la bala y configurar su dirección
                GameObject bala = Instantiate(singleBullet, transform.position, Quaternion.identity);
                Rigidbody2D rb = bala.GetComponent<Rigidbody2D>();
                rb.velocity = direccion * singleBulletSpeed;

                yield return new WaitForSeconds(1f);
                animator.SetBool("attacking", false);
            }
        

            if (opcion == 2)
            {
                bichosSpawn.SetActive(true);
                animator.SetBool("attacking", true);
                bichosSpawn.SetActive(true);
                eructosound.Play();
                yield return new WaitForSeconds(2f);
                bichosSpawn.SetActive(false);
                animator.SetBool("attacking", false);
            }
            else
            {
                animator.SetBool("attacking", true);
                spiralShoot.SetActive(true);
                eructosound.Play();
                yield return new WaitForSeconds(6f);
                spiralShoot.SetActive(false);
                animator.SetBool("attacking", false);
            }

            
            yield return new WaitForSeconds(tiempoEntreAcciones);
        }
    }



}
