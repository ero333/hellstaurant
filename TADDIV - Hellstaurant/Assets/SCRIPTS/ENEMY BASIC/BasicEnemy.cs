using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public bool flip;
    public float speed;
    public float distance;
    public PlayerMovement playermovement;

    public float KBPower = 100;
    public float KBDuration = 2;

    public PlayerHealthController playerhealthcontroller;
    



    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playermovement = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();

        playerhealthcontroller = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<PlayerHealthController>();
        
    }

    private void Update()
    {
        
        
            distance = Vector2.Distance(transform.position, player.transform.position); //calcula la cercania del jugador
            Vector2 direction = player.transform.position - transform.position; //calcula hacia donde va a ir el enemigo
            direction.Normalize();

            if (distance >= 0)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime); //desplaza al enemigo hacia el jugador
            }

            Vector3 scale = transform.localScale;  // toma la escala del sprite del enemigo

            if (player.transform.position.x > transform.position.x)
            {
                scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);   // si la posicion x del jugador es mayor a la del enemigo, flipea la escala del enemigo 
            }

            else
            {
                scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);       // lo mismo pero pal otro lado 
            }

            transform.localScale = scale;
        

        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(playerhealthcontroller.knockback(KBDuration, KBPower, this.transform));
        }
    }

}
    



