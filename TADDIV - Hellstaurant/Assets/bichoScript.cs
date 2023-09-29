using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bichoScript : MonoBehaviour
{

    public Transform jugador; // Asigna el jugador en el Inspector
    // Start is called before the first frame update
    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugador != null)
        {
            // Obt�n la direcci�n hacia el jugador
            Vector3 direccion = jugador.position - transform.position;

            // Calcula la rotaci�n para mirar hacia el jugador
            float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
            Quaternion rotacionHaciaJugador = Quaternion.AngleAxis(angulo, Vector3.forward);

            // Aplica la rotaci�n al Transform del enemigo
            transform.rotation = rotacionHaciaJugador;
        }
    }
    }
