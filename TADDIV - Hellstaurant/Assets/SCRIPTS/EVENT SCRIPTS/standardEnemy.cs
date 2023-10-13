using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standardEnemy : MonoBehaviour
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
            if (player != null)
            {
                player.lastAttackingEnemy = "BASICO";

                player.basicoHit++;
                player.hit++;
            }
        }
    }
}
