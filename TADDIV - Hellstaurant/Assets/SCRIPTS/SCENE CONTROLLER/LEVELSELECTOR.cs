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
        SceneManager.LoadScene("Nivel 0 (tutorial)");
    }

    public void lvl1()
    {
        SceneManager.LoadScene("Nivel 1");
    }

    public void lvl2()
    {
        SceneManager.LoadScene("Nivel 2");
    }

    public void lvl3()
    {
        SceneManager.LoadScene("Nivel 3");
    }
}