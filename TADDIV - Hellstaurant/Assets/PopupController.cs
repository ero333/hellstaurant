using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    public GameObject popupPanel;

    public void OpenPopup()
    {
        popupPanel.SetActive(true);
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
    }

    public void OnYesButtonClick()
    {
        // Handle "Yes" button click action here.
        ClosePopup();
    }

    public void OnNoButtonClick()
    {
        // Handle "No" button click action here.
        ClosePopup();
    }
}
