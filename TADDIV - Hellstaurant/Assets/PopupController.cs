using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PopupController : MonoBehaviour
{
    public GameObject popupPanel;
    public GameObject ventanaEmergente;
    public GameObject menuPrincipal;


    public void OpenPopup()
    {
        popupPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(ventanaEmergente.GetComponentInChildren<Button>().gameObject);
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(menuPrincipal.GetComponentInChildren<Button>().gameObject);
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
