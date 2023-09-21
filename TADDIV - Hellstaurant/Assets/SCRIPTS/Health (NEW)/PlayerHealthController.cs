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

    public bool isHealing = true; //verificar si el enemigo se esta curando o no

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

            if (invincibleCounter <= 0)
            {
                // invulnerable 
                isHealing = false;
                StopCoroutine(colorchange());
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (currentHealth < maxHealth)
            {
                isHealing = true; // Comienza la curaci�n
                StartCoroutine(healingProcess());
            }
        }
    }

    IEnumerator healingProcess()
    {
        anim.SetBool("Curandose", true);
        isHealing = true; // establece isHealing en true al comenzar la curaci�n
        yield return new WaitForSeconds(2f);

        currentHealth++;
        UIController.Instance.UpdateHealthDisplay();

        anim.SetBool("Curandose", false);
        isHealing = false; // establece isHealing en false al terminar la curaci�n
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

