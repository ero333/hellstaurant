using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform player; // Asigna el objeto del jugador desde el Editor de Unity
    public float shootingDistance = 5f; // Distancia a la que el enemigo comenzará a disparar

    private Animator animator;
    public EnemyShooting enemyshooting;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Calcula la distancia entre el enemigo y el jugador
        


    }

    public void ifClose()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        // Si la distancia es menor o igual a la distancia de disparo, cambia al estado de disparar
        if (distanceToPlayer <= shootingDistance)
        {
            enemyshooting = GetComponent<EnemyShooting>();
            enemyshooting.shooting();
        }
    }
}

