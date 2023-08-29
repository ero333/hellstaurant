using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public static UIController Instance; //Instancia este script

    public Image Life1;
    public Image Life2;  // Referencias a los 3 corazones
    public Image Life3;

    public Sprite heartFull, heartEmpty, heartMid;  //Referencias a los diferentes sprites que pueden tener

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this; //Instancia el script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthDisplay()
    {
        switch(PlayerHealthController.instance.currentHealth)   //Lista completa de todos los estados que puede tener la barra de vida, el cuál se actualiza según el valor de currentHealth 
        {

            case 6:
                Life1.sprite = heartFull;
                Life2.sprite = heartFull;
                Life3.sprite = heartFull;
                break;


             case 5:

                Life1.sprite = heartFull;
                Life2.sprite = heartFull;
                Life3.sprite = heartMid;
                break;


            case 4:

                Life1.sprite = heartFull;
                Life2.sprite = heartFull;
                Life3.sprite = heartEmpty;
                break;


            case 3:

                Life1.sprite = heartFull;
                Life2.sprite = heartMid;
                Life3.sprite = heartEmpty;
                break;

            case 2:

                Life1.sprite = heartFull;
                Life2.sprite = heartEmpty;
                Life3.sprite = heartEmpty;
                break;

            case 1:

                Life1.sprite = heartMid;
                Life2.sprite = heartEmpty;
                Life3.sprite = heartEmpty;
                break;

            case 0:

                Life1.sprite = heartEmpty;
                Life2.sprite = heartEmpty;
                Life3.sprite = heartEmpty;
                break;
        }
    }
}
