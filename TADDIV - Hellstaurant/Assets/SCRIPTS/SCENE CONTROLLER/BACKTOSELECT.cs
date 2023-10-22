using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BACKTOSELECT : MonoBehaviour
{
    public AudioSource buttonsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backToSelect()
    {
        buttonsound.Play();
        SceneManager.LoadScene("Selector de Niv");
    }

    public void backToMenu()
    {
        buttonsound.Play();
        SceneManager.LoadScene("Menu");
    }
}
