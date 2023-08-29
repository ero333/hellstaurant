using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public int currentHealth, maxHealth;

    public float invincibleLength;
    private float invincibleCounter;

    private SpriteRenderer theSR;

    public UIController controlUI;

    public GameObject gameOverScreen; // Referencia al cartel de Game Over

    public static PlayerHealthController instance;

    public AdvanceTime advanceTime;

    public Puntaje puntaje;

    public Animator anim;

    

   





    void Start()
    {
        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();
        anim = gameObject.GetComponent<Animator>();
    }

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (invincibleCounter > 0)
        {
            invincibleCounter -= Time.deltaTime;

            if (invincibleCounter <= 0) // Corrección aquí
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Heal();
        }

    }
    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        UIController.Instance.UpdateHealthDisplay();
    }

    void Heal()
    {
        if (currentHealth < maxHealth)
        {
            StartCoroutine(healingProcess());
        }
    }

    IEnumerator healingProcess()
    {
        anim.SetBool("Curandose", true);
        yield return new WaitForSeconds(1f);

        currentHealth++;
        UIController.Instance.UpdateHealthDisplay();

        anim.SetBool("Curandose", false);

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            DealDamage();
        }
    }

    public void DealDamage()
    {
        if (invincibleCounter <= 0)
        {
            currentHealth--;
            
            if (puntaje.puntos >= 10)
            {
                puntaje.puntos = puntaje.puntos - 10;
            }
            

            if (currentHealth <= 0)
            {
                advanceTime.playerAlive = false;
                currentHealth = 0;
                gameObject.SetActive(false);

                ShowGameOver(); // Mostrar el cartel de Game Over
            }
            else
            {
                invincibleCounter = invincibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 0.5f); // Cambio de alfa corregido
            }

            UIController.Instance.UpdateHealthDisplay();
        }
    }

    void ShowGameOver()
    {
        if (gameOverScreen != null)
        {
            
            gameOverScreen.SetActive(true); // Activar el cartel de Game Over
           
        }
    }
}

