using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public bool isCoin;

    private bool isCollected; //destruir monedas una vez agarradas

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isCollected)
        {
            if (isCoin)
            {
                UIController.Instance.coinsCollected++; //conteo de monedas


                UIController.Instance.UpdateCoinCount(); //Iniciar conteo monedas


                isCollected = true;
                Destroy(gameObject); //destruir monedas una vez agarradas 
            }
        }
    }
}
