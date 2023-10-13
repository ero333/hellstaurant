using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arañaEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerHealthController player = other.gameObject.GetComponent<PlayerHealthController>();
            if (player != null && player.invincibleLength <=0)
            {
                player.lastAttackingEnemy = "ARAÑA";

                player.arañaHit++;
                player.hit++;
            }
        }
    }
}
