using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject pizzaPrefab;
    public Transform enemyContainer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
    }

    private void Shooting()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject nearestEnemy = null;
        float shortestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if (distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            // Spawn bullet and set its direction towards the nearest enemy
            GameObject pizza = Instantiate(pizzaPrefab, transform.position, Quaternion.identity);
            Vector3 directionToEnemy = (nearestEnemy.transform.position - transform.position).normalized;
            pizza.GetComponent<Pizza>().SetDirection(directionToEnemy);
        }
    }
}
