using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player;
    public bool flip;
    public float speed;
    public float distance;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position); //calcula la cercania del jugador
        Vector2 direction = player.transform.position - transform.position; //calcula hacia donde va a ir el enemigo
        direction.Normalize(); 

        if (distance >= 0) {
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


} 
