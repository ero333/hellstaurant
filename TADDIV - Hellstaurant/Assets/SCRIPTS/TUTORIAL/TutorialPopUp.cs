using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopUp : MonoBehaviour
{

    public GameObject popUpPanel;

    void Start()
    {
        // Mostrar el pop-up al iniciar la aplicación
        MostrarPopUp();
    }

    public void MostrarPopUp()
    {
        popUpPanel.SetActive(true);
    }

    public void CerrarPopUp()
    {
        popUpPanel.SetActive(false);
    }
}

