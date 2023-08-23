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

    public static PlayerHealthController instance;

    void Start()
    {
        currentHealth = maxHealth;
        theSR = GetComponent<SpriteRenderer>();
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
    }

    public void OnTriggerEnter2D(Collider2D other)
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

            if (currentHealth <= 0)
            {
                currentHealth = 0;
                gameObject.SetActive(false);
            }
            else
            {
                invincibleCounter = invincibleLength;
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 0.5f); // Cambio de alfa corregido
            }

            UIController.Instance.UpdateHealthDisplay();
        }
    }
}

