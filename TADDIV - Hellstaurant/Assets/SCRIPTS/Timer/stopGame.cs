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
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void OnEnable()
    {

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }
        player.SetActive(false);
        spawner.StopAllCoroutines();
        spawner.deleteClones();

        

    }
}
