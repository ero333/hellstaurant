using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEDamage : MonoBehaviour
{

    public int puntosVidacaja;

    public AOEDamage instance;


    public void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        puntosVidacaja = 8;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            puntosVidacaja--;

            if(puntosVidacaja <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
