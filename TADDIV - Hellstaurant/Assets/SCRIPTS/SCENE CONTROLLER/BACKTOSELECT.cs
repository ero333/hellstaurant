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
        buttonsound = GameObject.FindGameObjectWithTag("sonidoboton").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backToSelect()
    {
        if (buttonsound != null)
        {
            buttonsound.Play();
        }
        SceneManager.LoadScene("Selector de Niv");
    }

    public void backToMenu()
    {
        if (buttonsound != null)
        {
            buttonsound.Play();
        }
        SceneManager.LoadScene("Menu");
    }
}
