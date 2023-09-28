using UnityEngine;

public class RotacionConstante : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación en grados por segundo

    public Puntaje puntaje;
    public int damageAmount = 1; // Daño que inflige la bala al jugador


    public void Start()
    {
        puntaje = GameObject.FindGameObjectWithTag("Score").GetComponent<Puntaje>();
    }

    private void Update()
    {
        // Rotar la bala constantemente
        transform.Rotate(Vector3.forward * velocidadRotacion * Time.deltaTime);

        lifetime();
    }

    public void lifetime()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Verifica si el objeto colisionado tiene el componente PlayerHealthController
            PlayerHealthController playerHealthController = other.GetComponent<PlayerHealthController>();
            if (playerHealthController != null)
            {
                playerHealthController.TakeDamage(damageAmount);

                if (puntaje.puntos >= 10)
                {
                    puntaje.puntos = puntaje.puntos - 10;
                }
            }

            Destroy(this.gameObject); // destruye la bala al colisionar con el jugador
        }
    }
}

