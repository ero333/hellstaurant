using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BACKTOMENU : MonoBehaviour
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

    public void backToMenu()
    {
        
        if (buttonsound != null)
        {
            buttonsound.Play();
        }

        SceneManager.LoadScene("Menu");
    }
}
