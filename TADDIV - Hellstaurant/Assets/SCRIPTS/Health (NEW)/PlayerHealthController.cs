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

    public PlayerMovement playerMovement;

    public Rigidbody2D rb2d;

  

    void Start()
    {
        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();

        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        anim = gameObject.GetComponent<Animator>();

        rb2d = gameObject.GetComponent<Rigidbody2D>();

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

                StopCoroutine(colorchange());
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
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
            playerMovement.isHealing = true;
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
        playerMovement.isHealing = false;
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
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), true);
                StartCoroutine(colorchange());

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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            DealDamage();

        }
    }


    public IEnumerator knockback(float KBDuration, float KBPower, Transform obj)
    {
        float KBTimer = 0;

        while (KBTimer < KBDuration) 
        { 
            KBTimer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;

            
            

            rb2d.AddForce(- direction* KBPower);

        }
        
        yield return 0;

    }

    public IEnumerator colorchange()
    {
        theSR.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.white;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.gray;
        yield return new WaitForSeconds(0.2f);
        theSR.color = Color.white;
        yield return new WaitForSeconds(0.2f);

    }
}

