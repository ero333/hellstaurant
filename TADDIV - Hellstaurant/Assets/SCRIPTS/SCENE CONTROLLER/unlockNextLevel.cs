using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class unlockNextLevel : MonoBehaviour
{
    public static unlockNextLevel Instance; 

    public int nivelesDesbloqueados;


    private static bool existing = false;


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
        
        PlayerPrefs.GetInt("Niveles desbloqueados:", nivelesDesbloqueados);



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void unlocklevel()
    { 

        nivelesDesbloqueados = nivelesDesbloqueados + 1;

        PlayerPrefs.SetInt("Niveles desbloqueados:", nivelesDesbloqueados);


    }
}
