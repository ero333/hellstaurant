using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class battleMusicOn : MonoBehaviour
{

    public AudioSource musicaNivel;
    
    public GameObject musicaMenu;


    // Start is called before the first frame update
    void Awake()
    {
        musicaMenu = GameObject.FindGameObjectWithTag("musicamenu");
    }

    // Update is called once per frame
    void Update()
    {
        //if (SceneManager.GetActiveScene().buildIndex >= 4 && SceneManager.GetActiveScene().buildIndex <= 18)
        //{
        //    musicaMenu.SetActive(false);
        //}
        //else
        //{
        //    musicaMenu.SetActive(true);
        //}

    }
}
