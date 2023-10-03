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



    public unlockNextLevel levelUnlockCheck;

    // Start is called before the first frame update
    void Start()
    {
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
        }

    // Update is called once per frame
    void Update()
    {
         // Verificar si se presionó la tecla "P" para desbloquear todos los niveles.
        if (Input.GetKeyDown(KeyCode.P))
        {
            UnlockAllLevels();
        }
    }


    // Función para desbloquear todos los niveles.
    private void UnlockAllLevels()
    {
        // Cambia este valor al número de niveles que tengas en tu juego.

        PlayerPrefs.SetInt("UltimoNivelAlcanzado", 13);
        PlayerPrefs.SetInt("Niveles desbloqueados:", 13);
        Debug.Log("DESBLOQUEASTE TODO WACHIN");
        
    }
}
