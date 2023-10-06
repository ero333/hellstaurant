using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stopGame : MonoBehaviour
{

    public string tagEnemy = "Enemy";

    public GameObject player;

    public EnemySpawner spawner;
    public EnemySpawner spawner2;
    public EnemySpawner spawner3;

    public int ultimoNivelDesbloqueado;

    public int nivelActual;


    public unlockNextLevel levelunlocking;


    public static stopGame instance;

    public GameObject bulletSpawner;

    public AudioSource winSound;


    private void Awake()
    {
        instance = this; 
    }

    // Start is called before the first frame update
    void Start()
    {
        nivelActual = SceneManager.GetActiveScene().buildIndex;

        ultimoNivelDesbloqueado = PlayerPrefs.GetInt("UltimoNivelAlcanzado");

        levelunlocking = GameObject.FindGameObjectWithTag("unlocker").GetComponent<unlockNextLevel>();


        levelunlocking.unlocklevel();


        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 1);
        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 2);
        }
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 3);
        }

        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 4);
        }
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void OnEnable()
    {
        winSound.Play();

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }
        player.SetActive(false);
        spawner.StopAllCoroutines();
        spawner.deleteClones();
        bulletSpawner.SetActive(false);


    }

    public void Tienda ()
    {
        SceneManager.LoadScene("Tienda");
    }
}
