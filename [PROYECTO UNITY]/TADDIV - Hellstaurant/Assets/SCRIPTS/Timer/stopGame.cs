using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopGame : MonoBehaviour
{

    public GameObject player;

    public GameObject enemy;

    public EnemySpawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void OnEnable()
    {
        player.SetActive(false);
        enemy.SetActive(false);
        spawner.canSpawn = false;
    }
}
