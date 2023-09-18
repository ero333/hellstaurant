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



    // Start is called before the first frame update
    void Start()
    {

        ultimoNivelDesbloqueado = PlayerPrefs.GetInt("NivelActual:", SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    public void OnEnable()
    {

        PlayerPrefs.SetInt("NivelActual:", SceneManager.GetActiveScene().buildIndex);

        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            Destroy(obj);


        }
        player.SetActive(false);
        spawner.stopSpawn();
        spawner.deleteClones();
        
    }
}
