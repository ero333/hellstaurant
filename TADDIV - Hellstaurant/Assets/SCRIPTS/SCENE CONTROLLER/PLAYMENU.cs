using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYMENU : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void jugar()
    {
        SceneManager.LoadScene("Selector de Niv");
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }

    public void creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

}
