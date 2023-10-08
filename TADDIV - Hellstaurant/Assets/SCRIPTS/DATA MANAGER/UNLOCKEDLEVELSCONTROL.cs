using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNLOCKEDLEVELSCONTROL : MonoBehaviour
{
    public GameObject blocklevel1;
    public GameObject level1Button;

    public GameObject blocklevel2;
    public GameObject level2Button;

    public GameObject blocklevel3;
    public GameObject level3Button;

    public GameObject blocklevel4;
    public GameObject level4Button;

    public GameObject blocklevel5;
    public GameObject level5Button;

    public GameObject blocklevel6;
    public GameObject level6Button;


    public GameObject blocklevel7;
    public GameObject level7Button;


    public GameObject blocklevel8;
    public GameObject level8Button;


    public GameObject blocklevel9;
    public GameObject level9Button;


    public GameObject blocklevel10;
    public GameObject level10Button;

    public GameObject blocklevel11;
    public GameObject level11Button;

    public GameObject blocklevel12;
    public GameObject level12Button;

    public GameObject blocklevel13;
    public GameObject level13Button;

    public GameObject blocklevel14;
    public GameObject level14Button;


    public GameObject endlessButton;


    public unlockNextLevel levelUnlockCheck;

    // Start is called before the first frame update
    void Start()
    {

        endlessButton.SetActive(false);

        PlayerPrefs.GetInt("UltimoNivelAlcanzado"); ;

        blocklevel1.SetActive(true);
        level1Button.SetActive(false);

        blocklevel2.SetActive(true);
        level2Button.SetActive(false);

        blocklevel3.SetActive(true);
        level3Button.SetActive(false);

        blocklevel4.SetActive(true);
        level4Button.SetActive(false);

        blocklevel5.SetActive(true);
        level5Button.SetActive(false);

        blocklevel6.SetActive(true);
        level6Button.SetActive(false);

        blocklevel7.SetActive(true);
        level7Button.SetActive(false);

        blocklevel8.SetActive(true);
        level8Button.SetActive(false);

        blocklevel9.SetActive(true);
        level9Button.SetActive(false);

        blocklevel10.SetActive(true);
        level10Button.SetActive(false);

        blocklevel11.SetActive(true);
        level11Button.SetActive(false);

        blocklevel12.SetActive(true);
        level12Button.SetActive(false);

        blocklevel13.SetActive(true);
        level13Button.SetActive(false);

        blocklevel14.SetActive(true);
        level14Button.SetActive(false);









    }

    // Update is called once per frame
    void Update()
    {
         // Verificar si se presionó la tecla "P" para desbloquear todos los niveles.
        if (Input.GetKeyDown(KeyCode.P))
        {
            UnlockAllLevels();
        }


        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 4)
        {
            blocklevel1.SetActive(false);
            level1Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 5)
        {
            blocklevel2.SetActive(false);
            level2Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 6)
        {
            blocklevel3.SetActive(false);
            level3Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 7)
        {
            blocklevel4.SetActive(false);
            level4Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 9)
        {
            blocklevel5.SetActive(false);
            level5Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 10)
        {
            blocklevel6.SetActive(false);
            level6Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 11)
        {
            blocklevel7.SetActive(false);
            level7Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 12)
        {
            blocklevel8.SetActive(false);
            level8Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 13)
        {
            blocklevel9.SetActive(false);
            level9Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 14)
        {
            blocklevel10.SetActive(false);
            level10Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 15)
        {
            blocklevel11.SetActive(false);
            level11Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 16)
        {
            blocklevel12.SetActive(false);
            level12Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 17)
        {
            blocklevel13.SetActive(false);
            level13Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 18)
        {
            blocklevel14.SetActive(false);
            level14Button.SetActive(true);
        }


        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 20)
        {
            endlessButton.SetActive(true);
        }


    }


    // Función para desbloquear todos los niveles.
    private void UnlockAllLevels()
    {
        // Cambia este valor al número de niveles que tengas en tu juego.

        PlayerPrefs.SetInt("UltimoNivelAlcanzado", 20);
        PlayerPrefs.SetInt("Niveles desbloqueados:", 20);
        Debug.Log("DESBLOQUEASTE TODO WACHIN");
        
    }
}
