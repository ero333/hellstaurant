using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EliminateImage : MonoBehaviour
{
    public Image imageToEliminate;

    private void Start()
    {
        // Ensure you have assigned the Image component you want to eliminate in the Inspector.
        if (imageToEliminate == null)
        {
            Debug.LogError("Please assign the Image component you want to eliminate.");
            enabled = false; // Disable the script to prevent errors.
        }
    }

    public void OnButtonClick()
    {
        // Check if the image is not null, then disable it to "eliminate" it.
        if (imageToEliminate != null)
        {
            imageToEliminate.gameObject.SetActive(false);
        }
    }
}
