using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEXTSCENE : MonoBehaviour
{
    public static NEXTSCENE Instance;

    public int currentLevel;
    public unlockNextLevel levelUnlock;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        levelUnlock = GameObject.FindGameObjectWithTag("unlocker").GetComponent<unlockNextLevel>();
        currentLevel = SceneManager.GetActiveScene().buildIndex;

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            skipTutorial(); 
        }
    }

    public void NextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 1);
        }
        if (SceneManager.GetActiveScene().buildIndex == 10)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 2);
        }
        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 3);
        }

        if (SceneManager.GetActiveScene().buildIndex == 12)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 4);
        }

        Time.timeScale = 1.0f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);


    }

    public void skipTutorial()
    {
        Time.timeScale = 1.0f;
        levelUnlock.skipTutorial();
    }



    public void playEndless()
    {

        PlayerPrefs.SetInt("UltimoNivelAlcanzado", 20);
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }



}
