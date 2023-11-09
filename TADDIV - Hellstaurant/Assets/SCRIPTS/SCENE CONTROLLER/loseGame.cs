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


    public GameObject botonOmitir;

    // Start is called before the first frame update
    void Start()
    {
        winscreen = GameObject.FindGameObjectWithTag("winscreen"); 

        deathdebug = GameObject.FindGameObjectWithTag("debugDeath");


        loseSound = GameObject.FindGameObjectWithTag("sonidolose").GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (winscreen != null)
        {
            winscreen.SetActive(false);
        }

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

        if (botonOmitir != null)
        {
            botonOmitir.SetActive(false);
        }

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }

        if (spawner != null)
        {

            spawner.StopAllCoroutines();

            spawner.deleteClones();

        }

        enemiespawner.SetActive(false);

        if (potenciadoresspawner != null)
        {
            potenciadoresspawner.SetActive(false);
        }


        yield return new WaitForSeconds(0.6f);

        player.SetActive(false);

        if (bulletSpawner != null)
        {
            bulletSpawner.SetActive(false);
        }

    }
}
