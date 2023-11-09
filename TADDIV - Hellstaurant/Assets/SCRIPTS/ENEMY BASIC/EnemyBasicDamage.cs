using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBasicDamage : MonoBehaviour
{
    public double enemyLife; // Variable de la vida del enemigo
    public int puntosEnemigo;
    public GameObject contadorPuntos;
    public Puntaje puntaje;
    [Range(0, 100)] public float chanceToDrop; // enemigo dropea monedas
    public GameObject collectible; // lo que vamos a dropear

    public int amountToDrop; // Cantidad de monedas a dropear

    public AudioSource hitSound;



    void Start()
    {
        contadorPuntos = GameObject.FindGameObjectWithTag("Score");
        puntaje = contadorPuntos.GetComponent<Puntaje>();

        hitSound = GameObject.FindGameObjectWithTag("sonidohitenemigo").GetComponent<AudioSource>();

        
    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other) // Cuando colisionan la pizza y el enemigo
    {
        if (other.CompareTag("PizzaShoot")) // Si la pizza tiene el tag PizzaShoot
        {
            

            enemyLife--; // Le baja 1 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�
            hitSound.Play();

            


            if (enemyLife <= 0)
            {
                


                onDeath();
            }
        }

        if (other.CompareTag("FugazzettaShoot")) // Si la pizza tiene el tag FugazzettaShoot
        {
            enemyLife = enemyLife -2; // Le baja 2 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�
            hitSound.Play();

            if (enemyLife <= 0)
            {

                onDeath();
            }
        }

        if (other.CompareTag("FainaShoot")) // Si la pizza tiene el tag FainaShoot
        {
            enemyLife = enemyLife - 0.5; // Le baja 0.5 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�
            hitSound.Play();

            if (enemyLife <= 0)
            {


                onDeath();
            }
        }

        if (other.CompareTag("PicanteShoot")) // Si la pizza tiene el tag FainaShoot
        {
            enemyLife = enemyLife - 3; // Le baja 3 de vida al enemigo
            Destroy(other.gameObject); // Destruye la pizza que le peg�
            hitSound.Play();

            if (enemyLife <= 0)
            {

                onDeath();
            }
        }

        if (other.CompareTag("CajaShoot")) // Si la pizza tiene el tag CajaShoot
        {
            enemyLife = enemyLife - 2; // Le baja 2 de vida al enemigo
            hitSound.Play();
            

            if (enemyLife <= 0)
            {

                onDeath();
            }
        }
    }

    public void onDeath()
    {

        StartCoroutine(deathCorrutine());

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


    IEnumerator deathCorrutine()
    {
        
        yield return new WaitForSeconds(0.2f);
        puntaje.obtenerPuntaje(puntosEnemigo);


        Destroy(gameObject); // Cuando la vida es menor o igual a cero se destruye el enemigo

    }
}
