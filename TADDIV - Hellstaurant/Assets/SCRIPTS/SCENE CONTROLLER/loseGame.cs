using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loseGame : MonoBehaviour
{

    public string tagEnemy = "Enemy";

    public GameObject player;

    public EnemySpawner spawner;
    public EnemySpawner spawner2;
    public EnemySpawner spawner3;

    public AudioSource loseSound;

    public GameObject bulletSpawner;

    [SerializeField] private GameObject winscreen;

    public GameObject enemiespawner;

    public GameObject potenciadoresspawner;

    [SerializeField] private GameObject deathdebug;

    // Start is called before the first frame update
    void Start()
    {
        winscreen = GameObject.FindGameObjectWithTag("winscreen"); 

        deathdebug = GameObject.FindGameObjectWithTag("debugDeath");
    }
    // Update is called once per frame
    void Update()
    {
        winscreen.SetActive(false);
    }

    public void OnEnable()
    {

       deathdebug.SetActive(true);

      StartCoroutine(loseProcess());

    }

    public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }


    IEnumerator loseProcess()
    {
        loseSound.Play();

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }

        spawner.StopAllCoroutines();

        spawner.deleteClones();

        enemiespawner.SetActive(false);

        potenciadoresspawner.SetActive(false);

        yield return new WaitForSeconds(0.6f);

        player.SetActive(false);

        bulletSpawner.SetActive(false);
    }
}
