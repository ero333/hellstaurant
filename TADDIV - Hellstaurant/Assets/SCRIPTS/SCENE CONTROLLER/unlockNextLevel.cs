using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlockNextLevel : MonoBehaviour
{
    public static unlockNextLevel Instance; 

    public int nivelesDesbloqueados;


    private static bool existing = false;

    public stopGame winscreen;

    public int nivelactual;

    public int lastlevel;


    private void Awake()
    {
        Instance = this;

        if (!existing)
        {
            
            DontDestroyOnLoad(this.gameObject);
            existing = true;
        }
        else
        {
           
            Destroy(this.gameObject);
        }

       

    }
    // Start is called before the first frame update
    void Start()
    {

        winscreen = GameObject.FindGameObjectWithTag("winscreen").GetComponent<stopGame>();


        
        


    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("NivelActual", SceneManager.GetActiveScene().buildIndex);

        nivelactual = PlayerPrefs.GetInt("NivelActual");

        lastlevel = PlayerPrefs.GetInt("UltimoNivelAlcanzado");
    }

    public void unlocklevel()
    { 

       if (nivelactual > lastlevel)
        {


            PlayerPrefs.SetInt("UltimoNivelAlcanzado", nivelactual);

            nivelesDesbloqueados = nivelesDesbloqueados + 1;

            PlayerPrefs.SetInt("Niveles desbloqueados:", nivelesDesbloqueados);

            Debug.Log("DESBLOQUEASTE WACHIN");
        }

        else
        {
            Debug.Log("Sos Re Wachin");
        }

    }


    public void skipTutorial()
    {

        if (nivelactual > lastlevel)
        {
            PlayerPrefs.SetInt("UltimoNivelAlcanzado", SceneManager.GetActiveScene().buildIndex);   
        }


        SceneManager.LoadScene("Nivel 1");

    }
}
