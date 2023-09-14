using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpManager : MonoBehaviour
{


    public GameObject spawnerFuga;
    public GameObject spawnerFaina;
    public GameObject spawnerCaja;
    public GameObject spawnerFrenzy;

    

    // Start is called before the first frame update
    void Start()

    {

        spawnerCaja.SetActive(false);
        spawnerFrenzy.SetActive(false);
        spawnerFaina.SetActive(false);
        spawnerFuga.SetActive(false);


        

        if (PlayerPrefs.GetInt ("FugazzettaUnlocked") >= 1)
        {
        
            spawnerFuga.SetActive(true);

        }
        if (PlayerPrefs.GetInt("FainaUnlocked") >= 1)
        {

            
            spawnerFaina.SetActive(true);

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
