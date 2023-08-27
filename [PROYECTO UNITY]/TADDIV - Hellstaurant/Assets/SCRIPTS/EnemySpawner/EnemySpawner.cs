using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour{
  
 public float spawnRate = 1f;

 public GameObject[] enemyPrefabs;

public bool canSpawn = true;

public List<GameObject> enemyClones = new List<GameObject>();

    public void Start () {
	StartCoroutine(Spawner());
	}

public IEnumerator Spawner () {
	WaitForSeconds wait = new WaitForSeconds(spawnRate);

	while (canSpawn) {
		yield return wait;
		int rand = Random.Range(0, enemyPrefabs.Length);
		GameObject enemyToSpawn = enemyPrefabs[rand];

		GameObject enemyClone = Instantiate(enemyToSpawn, transform.position, Quaternion.identity);
		enemyClones.Add(enemyClone);

    }
}

	public void stopSpawn()
	{
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

