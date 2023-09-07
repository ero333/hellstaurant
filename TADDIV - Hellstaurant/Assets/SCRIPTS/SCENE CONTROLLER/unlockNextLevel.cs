using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockNextLevel : MonoBehaviour
{
    public static unlockNextLevel Instance; 
    public int nivelesDesbloqueados;



    private void Awake()
    {
        Instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
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
