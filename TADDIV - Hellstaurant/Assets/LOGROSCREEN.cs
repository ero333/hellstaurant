using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LOGROSCREEN : MonoBehaviour
{

    public Button logro1;
    public Button logro2;    
    public Button logro3; 
    public Button logro4;
    public Button logro5;   
    public Button logro6;
    public Button logro7;
    public Button logro8;
    public Button logro9;
    public Button logro10;

    public achievementManager achievementObject;


    // Start is called before the first frame update
    void Start()
    {

        achievementObject = GameObject.FindGameObjectWithTag ("achievementManager").GetComponent<achievementManager> ();

        logro1.interactable = false;
        logro2.interactable = false;
        logro3.interactable = false;
        logro4.interactable = false;
        logro5.interactable = false;
        logro6.interactable = false;
        logro7.interactable = false;
        logro8.interactable = false;
        logro9.interactable = false;
        logro10.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {   
        
        if (PlayerPrefs.GetInt("logro1conseguido") >= 1)
        {

            logro1.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro2conseguido") >= 1)
        {

            logro2.interactable = true;
        }
        if (PlayerPrefs.GetInt("logro3conseguido") >= 1)
        {

            logro3.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro4conseguido") >= 1)
        {

            logro4.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro5conseguido") >= 1)
        {

            logro5.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro6conseguido") >= 1)
        {

            logro6.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro7conseguido") >= 1)
        {

            logro7.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro8conseguido") >= 1)
        {

            logro8.interactable = true;
        }

        if (PlayerPrefs.GetInt("logro9conseguido") >= 1)
        {

            logro9.interactable = true;
        }

        if (PlayerPrefs.GetInt("platinoconseguido") >= 1)
        {

            logro10.interactable = true;
        }

    }


   
}
