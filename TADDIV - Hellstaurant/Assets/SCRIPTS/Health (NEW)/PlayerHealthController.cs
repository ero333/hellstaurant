using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public int currentHealth, maxHealth;

    public int healingTimes = 0;

    public string lastAttackingEnemy;

    public GameObject playerDeathDebug;


    public int basicoHit = 0;
    public int gordoHit = 0;
    public int rapidoHit = 0;
    public int rodeteHit = 0;
    public int basicoPHit = 0;
    public int gordoPHit = 0;
    public int rapidoPHit = 0;
    public int rodetePHit = 0;
    public int arañaHit = 0;
    public int cucarachaHit = 0;
    public int bossHit = 0;

    public int hit = 0;




    public levelStart levelstart;

    public float invincibleLength;
    public float invincibleCounter;

    private SpriteRenderer theSR;

    public UIController controlUI;

    public GameObject gameOverScreen; 

    public static PlayerHealthController instance;

    public AdvanceTime advanceTime;


    public Puntaje puntaje;

    public Animator anim;

    public PlayerMovement playerMovement;

    public Rigidbody2D rb2d;

    public bool isHealing; 

    public AudioSource damageSound; 
    public AudioSource eatingSound;


    private float lastHealTime; 
    public float cooldown = 10.0f; 


    void Start()
    {
        playerDeathDebug.GetComponent<playerDebugControl>();

        isHealing = false;

        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);

        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();

        playerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        anim = gameObject.GetComponent<Animator>();

        rb2d = gameObject.GetComponent<Rigidbody2D>();


        puntaje = GameObject.FindGameObjectWithTag("Score").GetComponent<Puntaje>(); // Asigna el componente Puntaje
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

        if (Input.GetMouseButtonDown(1) && !isHealing)
        {
            if (currentHealth < maxHealth)
            {
                //isHealing = true; // Comienza la curaci�n
                //StartCoroutine(healingProcess());

                TryStartHealing();
            }
        }

        if (Input.GetKeyDown(KeyCode.E) && !isHealing)
        {
            if (currentHealth < maxHealth)
            {
                //isHealing = true; // Comienza la curaci�n
                //StartCoroutine(healingProcess());

                TryStartHealing();
            }
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton5) && !isHealing)
        {
            if (currentHealth < maxHealth)
            {
                //isHealing = true; // Comienza la curaci�n
                //StartCoroutine(healingProcess());

                TryStartHealing();
            }
        }


        void TryStartHealing()
        {

            if (Time.time - lastHealTime > cooldown)
            {
                if (currentHealth < maxHealth)
                {
                    lastHealTime = Time.time; 
                    isHealing = true; 
                    StartCoroutine(healingProcess());
                }
            }
        }


    }

    IEnumerator healingProcess()
    {

        anim.SetBool("Curandose", true);
        isHealing = true; // establece isHealing en true al comenzar la curaci�n

        eatingSound.Play();

        yield return new WaitForSeconds(2f);


        currentHealth++;
        UIController.Instance.UpdateHealthDisplay();

        anim.SetBool("Curandose", false);

        healingTimes++;

        isHealing = false; // establece isHealing en false al terminar la curaci�n
    }

    public void DealDamage()
    {
        if (invincibleCounter <= 0)
        {
            currentHealth--;

            if (currentHealth <= 0)
            {

                StartCoroutine(death());

            }
            else
            {
                invincibleCounter = invincibleLength;
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), true);
                StartCoroutine(colorchange());
            }

            UIController.Instance.UpdateHealthDisplay();

            if (puntaje.puntos >= 10)
            {
                puntaje.puntos = puntaje.puntos - 10;
            }
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
            damageSound.Play();

            DealDamage();

        }
    }


    public void TakeDamage(int damage)
    {
        if (invincibleCounter <= 0)
        {
            currentHealth -= damage;

            if (currentHealth <= 0)
            {

                StartCoroutine(death());
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

    public IEnumerator death()
    {
        levelstart.timerRunning = false;
        advanceTime.playerAlive = false;


        currentHealth = 0;



        yield return new WaitForSeconds(0.05f);

        ShowGameOver(); // Mostrar el cartel de Game Over
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

