using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockItemHandler : MonoBehaviour
{
    [SerializeField] Button[] buttons;
    int UnlockedItemsNumber;


    private void Start()
    {
        if (!PlayerPrefs.HasKey("itemsUnlocked")) {
            PlayerPrefs.SetInt("itemsUnlocked", 1);
        }

        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");
        for (int i=0; i<buttons.Length; i++) {
        buttons[i].interactable = false;
        }
    }

    private void Update()
    {
        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");
        for (int i=0; i<buttons.Length; i++) {
            buttons[i].interactable = true;
        }
    }
}
