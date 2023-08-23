using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public int currentHealth, maxHealth; //Referencias a la vida actual y la vida llena

    public UIController controlUI; // Referencia al controlador de la UI del canvas

    public static PlayerHealthController instance; // Instancia este script para poder ser llamado desde otros

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //La vida actual se iguala a la vida máxima ni bien iniciamos el juego
    }

    private void Awake()
    {
        instance = this; //Activa la instancia para ser llamado
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            DealDamage(); //Cuando colisiona con un objeto con el tag Enemy, llama a DealDamage
        }
        
    }

    public void DealDamage()
    {
        currentHealth--; //Resta 1 punto de vida 

        UIController.Instance.UpdateHealthDisplay(); //Actualiza los corazones

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false); //Cuando la vida es 0 desactiva al jugador
        }
    }

}
