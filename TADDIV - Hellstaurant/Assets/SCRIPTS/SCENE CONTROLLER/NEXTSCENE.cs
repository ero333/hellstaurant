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
        currentLevel = SceneManager.GetActiveScene().buildIndex;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void NextScene()
    {

        levelUnlock.unlocklevel();

        Time.timeScale = 1.0f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }



}
