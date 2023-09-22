using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELSELECTOR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void tutorial()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 0 (tutorial)");
    }

    public void lvl1()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 1");
    }

    public void lvl2()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 2");
    }

    public void lvl3()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 3");
    }

    public void lvl4()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 4");
    }

    public void lvl5()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 5");
    }

    public void lvl6()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Nivel 6");
    }

    public void lvl14()
    {
        PlayerPrefs.SetInt("PartidaGuardada", 1);
        SceneManager.LoadScene("Cutscene");
    }
}
