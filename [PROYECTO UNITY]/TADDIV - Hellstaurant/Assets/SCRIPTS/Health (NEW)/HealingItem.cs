using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingItem : MonoBehaviour
{
    public int healAmount = 2; // vida recuperada
    public int maxUses = 3;      // numero de usos maximos

    private int remainingUses;    // usos restantes

    private void Start()
    {
        remainingUses = maxUses;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (remainingUses > 0 && other.CompareTag("Player"))
        {
            PlayerHealthController playerHealth = other.GetComponent<PlayerHealthController>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healAmount);
                remainingUses--;

                if (remainingUses <= 0)
                {
                    Destroy(gameObject); // Destroy the healing item after all uses are exhausted
                }
            }
        }
    }
}