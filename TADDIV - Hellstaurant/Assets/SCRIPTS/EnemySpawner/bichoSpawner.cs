using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bichoSpawner : MonoBehaviour
{
    public float spawnRate = 1f;

    public GameObject[] enemyPrefabs;

    public bool canSpawn = true;

    public List<GameObject> enemyClones = new List<GameObject>();



    public void OnEnable()
    {
        StartCoroutine(Spawner());
    }

    public IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn)
        {

            yield return wait;
            int rand = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];


            GameObject enemyClone = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);


            enemyClones.Add(enemyClone);

        }
    }

    public void stopSpawn()
    {
        StopCoroutine(Spawner());
        canSpawn = false;
    }

    public void deleteClones()
    {
        foreach (GameObject enemyClone in enemyClones)
        {
            Destroy(enemyClone);
        }
    }

}
