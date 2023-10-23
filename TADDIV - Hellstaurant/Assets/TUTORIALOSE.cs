using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUTORIALOSE : MonoBehaviour
{

    public GameObject tutorialcanvas;

    public void OnEnable()
    {
        tutorialcanvas.SetActive(false);
    }
}
