using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletstop : MonoBehaviour
{
    public GameObject bulletspawner;
    public GameObject bulletpool;
    public GameObject bulletburst;
    public GameObject spawnerbichos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletspawner.SetActive(false);
        bulletpool.SetActive(false);
        bulletburst.SetActive(false);
        spawnerbichos.SetActive(false);
    }
}
