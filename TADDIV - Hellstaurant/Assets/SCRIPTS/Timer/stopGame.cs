using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public GameObject enemiespawner;

    public GameObject potenciadoresspawner;

    public AudioSource winSound;

    public GameObject losescreen;


    public GameObject botonOmitir;

    public GameObject botonSiguiente;

    public GameObject popupPotenciador;

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



        winSound= GameObject.FindGameObjectWithTag("sonidowin").GetComponent<AudioSource>();


        levelunlocking.unlocklevel();

        losescreen = GameObject.FindGameObjectWithTag("losescreen");


        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 1);

            if (popupPotenciador != null)
            {
                popupPotenciador.SetActive(true);
            }

        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 2);

            if (popupPotenciador != null)
            {
                popupPotenciador.SetActive(true);
            }
        }
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 3);

            if (popupPotenciador != null)
            {
                popupPotenciador.SetActive(true);
            }
        }

        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 4);

            if (popupPotenciador != null)
            {
                popupPotenciador.SetActive(true);
            }
        }

        EventSystem.current.SetSelectedGameObject(botonSiguiente.GetComponentInChildren<Button>().gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        losescreen.SetActive(false);
    }

    public void OnEnable()
    {
        StartCoroutine(winProcess());
    }

    public void Tienda ()
    {
        SceneManager.LoadScene("Tienda");
    }

    IEnumerator winProcess()
    {
        if (winSound != null)
        {
            winSound.Play();
        }


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

        if (enemiespawner != null)
        {
            enemiespawner.SetActive(false);
        }

        if (potenciadoresspawner != null) 
        {
            potenciadoresspawner.SetActive(false);
                }

        yield return new WaitForSeconds(0.5f);

        player.SetActive(false);

        if (bulletSpawner != null)
        {
            bulletSpawner.SetActive(false);
        }


    }
}
