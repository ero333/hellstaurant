using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public bool isCoin;

    private bool isCollected; //destruir monedas una vez agarradas
    public float timeToDisappear = 5f; // Tiempo en que las monedas se destruyen si el jugador no las agarra

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

    // Si el jugador no agarra las monedas
    public void DestroyIfNotCollected()
    {
        if (!isCollected)
        {
            Destroy(gameObject); // Destruye las monedas despues de 5 segundos 
        }
    }

    // Start a la funcion de destuir las monedas si el jugador no las agarrar
    private void Start()
    {
        Invoke("DestroyIfNotCollected", timeToDisappear);
    }
}
