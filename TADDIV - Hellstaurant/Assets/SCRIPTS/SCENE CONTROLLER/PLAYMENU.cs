using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYMENU : MonoBehaviour
{

    public int hayPartida;

    public GameObject botonContinuar;

    // Start is called before the first frame update
    void Start()
    {
        hayPartida = PlayerPrefs.GetInt("PartidaGuardada");
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void jugar()
    {
        SceneManager.LoadScene("Selector de Niv");

        PlayerPrefs.SetInt("PartidaGuardada", 1);

        botonContinuar.SetActive(true);
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();

        PlayerPrefs.SetInt("PartidaGuardada", 0);

        botonContinuar.SetActive(false);
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
