using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotenciadores : MonoBehaviour

{
    public float spawnRate = 1f;

    public GameObject[] PowerUp;

    public bool canSpawn = true;

    public AudioSource spawnPoten;


    // Start is called before the first frame update
    void Start()
    {
        spawnPoten = GameObject.FindGameObjectWithTag("sonidospawn").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startSpawning()
    {
        StartCoroutine(PowerUpSpawn());
    }

    IEnumerator PowerUpSpawn ()
    {
        while (canSpawn)
        {
            WaitForSeconds wait = new WaitForSeconds(spawnRate);

            yield return wait;
            int rand = Random.Range(0, PowerUp.Length);
            GameObject PowerUpSp = PowerUp[rand];

            spawnPoten.Play();

            Instantiate(PowerUpSp, transform.position, Quaternion.identity);
        }
        
    }
}
