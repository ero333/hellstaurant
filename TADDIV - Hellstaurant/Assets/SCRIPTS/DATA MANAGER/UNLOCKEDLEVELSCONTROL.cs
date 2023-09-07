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

    public unlockNextLevel levelUnlockCheck;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Niveles desbloqueados:", levelUnlockCheck.nivelesDesbloqueados);

        blocklevel1.SetActive(true);
        level1Button.SetActive(false);

        blocklevel2.SetActive(true);
        level2Button.SetActive(false);

        blocklevel3.SetActive(true);
        level3Button.SetActive(false);


        if (PlayerPrefs.GetInt("Niveles desbloqueados:") >= 1)
        {
            blocklevel1.SetActive(false);
            level1Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Niveles desbloqueados:") >= 2)
        {
            blocklevel2.SetActive(false);
            level2Button.SetActive(true);
        }

        if (PlayerPrefs.GetInt("Niveles desbloqueados:") >= 3)
        {
            blocklevel3.SetActive(false);
            level3Button.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
