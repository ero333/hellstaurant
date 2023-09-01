using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float shootingRange = 5f;
    public GameObject projectilePrefab;
    public float projectileSpeed = 10f;
    public float shootingCooldown = 2f;

    private Transform player;
    private float lastShotTime = 0f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= shootingRange)
        {
            // Dentro del rango de disparo
            StopMoving();
            Shoot();
        }
        else
        {
            // Fuera del rango de disparo
            MoveTowardsPlayer();
        }
    }

    private void MoveTowardsPlayer()
    {
        Vector2 moveDirection = (player.position - transform.position).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    private void StopMoving()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    private void Shoot()
    {
        if (Time.time - lastShotTime > shootingCooldown)
        {
            Vector2 shootDirection = (player.position - transform.position).normalized;
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            Rigidbody2D projectileRb = newProjectile.GetComponent<Rigidbody2D>();
            if (projectileRb != null)
            {
                projectileRb.velocity = shootDirection * projectileSpeed;
            }
            lastShotTime = Time.time;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
