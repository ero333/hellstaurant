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
    // Start is called before the first frame update
    void Start()
    {

        levelUnlock = GameObject.FindGameObjectWithTag("unlocker").GetComponent<unlockNextLevel>();
        currentLevel = SceneManager.GetActiveScene().buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void NextScene()
    {

        if (SceneManager.GetActiveScene().buildIndex >= 7)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 1);
        }
        if (SceneManager.GetActiveScene().buildIndex >= 8)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 2);
        }
        if (SceneManager.GetActiveScene().buildIndex >= 9)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 3);
        }

        if (SceneManager.GetActiveScene().buildIndex >= 10)
        {
            PlayerPrefs.GetInt("itemsUnlocked");
            PlayerPrefs.SetInt("itemsUnlocked", 4);
        }

        //levelUnlock.unlocklevel();

        Time.timeScale = 1.0f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void skipTutorial()
    {
        Time.timeScale = 1.0f;
        levelUnlock.skipTutorial();
    }



}
