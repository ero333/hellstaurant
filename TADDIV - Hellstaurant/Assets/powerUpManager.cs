using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpManager : MonoBehaviour
{


    public GameObject spawnerFuga;
    public GameObject spawnerFaina;
    public GameObject spawnerCaja;
    public GameObject spawnerFrenzy;


    public int FugaUnlock;
    public int FainaUnlock;
    public int FrenzyUnlock;
    public int CajaUnlock;

    

    // Start is called before the first frame update
    void Start()

    {

        FugaUnlock = PlayerPrefs.GetInt("FugazzettaUnlocked");
        FainaUnlock = PlayerPrefs.GetInt("FainaUnlocked");


        spawnerCaja.SetActive(false);
        spawnerFrenzy.SetActive(false);
        spawnerFaina.SetActive(false);
        spawnerFuga.SetActive(false);


        

        if (PlayerPrefs.GetInt ("FugazzettaUnlocked") >= 1)
        {
        
            spawnerFuga.SetActive(true);
            spawnerFuga.GetComponent<SpawnPotenciadores>().startSpawning();
        }
        if (PlayerPrefs.GetInt ("FainaUnlocked") >= 1)
        {

            spawnerFaina.SetActive(true);
            spawnerFaina.GetComponent<SpawnPotenciadores>().startSpawning();

        }
        if (PlayerPrefs.GetInt("CajaUnlocked") >= 1)
        {

            spawnerCaja.SetActive(true);
            spawnerCaja.GetComponent<SpawnPotenciadores>().startSpawning();

        }
        if (PlayerPrefs.GetInt("FrenzyUnlocked") >= 1)
        {

            spawnerFrenzy.SetActive(true);
            spawnerFrenzy.GetComponent<SpawnPotenciadores>().startSpawning();

        }


        //if (currentPowerups <= 3)
        //{

        //    spawnerFuga.SetActive(true);
        //    spawnerFaina.SetActive(true);
        //    spawnerCaja.SetActive(true);

        //}
        //if (currentPowerups <= 4)
        //{

        //    spawnerFuga.SetActive(true);
        //    spawnerFaina.SetActive(true);
        //    spawnerCaja.SetActive(true);
        //    spawnerFrenzy.SetActive (true);

        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
