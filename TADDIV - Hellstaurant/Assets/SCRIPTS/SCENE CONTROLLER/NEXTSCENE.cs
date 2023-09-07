using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEXTSCENE : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public void NextScene()
    {
        Time.timeScale = 1.0f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnTriggerEnter()
    {
    if (buildIndex > 1)
    {
        Destroy.gameObject.tag("nivel1block");
    }
    }

}
