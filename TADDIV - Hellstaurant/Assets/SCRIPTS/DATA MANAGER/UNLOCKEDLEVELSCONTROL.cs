using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UNLOCKEDLEVELSCONTROL : MonoBehaviour
{
    public GameObject blocklevel1;
    public GameObject level1Button;

    public unlockNextLevel levelUnlockCheck;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Niveles desbloqueados:", levelUnlockCheck.nivelesDesbloqueados);

        blocklevel1.SetActive(true);
        level1Button.SetActive(false);


        if (PlayerPrefs.GetInt("Niveles desbloqueados:") == 1)
        {
            blocklevel1.SetActive(false);
            level1Button.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
