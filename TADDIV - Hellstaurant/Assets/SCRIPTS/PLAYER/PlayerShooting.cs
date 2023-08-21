using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject pizzaPrefab; //Objeto de la rodaja de pizza
    public Transform shootPoint; //Punto desde el que se dispara
    public float pizzaSpeed = 10f; //Velocidad a la que se dispara

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) //Al hacer click izquierdo
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Toma la posición del click
            Vector3 direction = (mousePosition - shootPoint.position).normalized; //Compara la posición del mouse a la posición de la cuál se va a disparar

            pizzaShoot(direction);
        }
    }

    public void pizzaShoot(Vector3 direction)
    {
        GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity); //Genera una pizza en el punto de disparo
        pizza.GetComponent<Rigidbody2D>().velocity = direction * pizzaSpeed; //Dispara esa pizza hacia el lugar del click que tomó anteriormente
    }
}