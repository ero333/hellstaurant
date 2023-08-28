using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject pizzaPrefab; //Objeto de la rodaja de pizza
    public Transform shootPoint; //Punto desde el que se dispara
    public float pizzaSpeed = 10f; //Velocidad a la que se dispara

    public float cooldown = 0.5f; // Cooldown que queremos para el disparo
    private float lastShoot; // �ltima vez que disparaste 


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - lastShoot >= cooldown) //Al hacer click izquierdo y calculando que el tiempo que paso entre el �ltimo disparo y el tiempo actual sea mayor al del cooldown
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Toma la posici�n del click
            Vector3 direction = (mousePosition - shootPoint.position).normalized; //Compara la posici�n del mouse a la posici�n de la cu�l se va a disparar

            pizzaShoot(direction);
        }
    }

    public void pizzaShoot(Vector3 direction)
    {
        GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity); //Genera una pizza en el punto de disparo

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //El Atan2 sirve para calcular la tangente entre 2 n�meros, en este caso X e Y del click del mouse. Y lo transforma en grados de un �ngulo con el Rad2Deg

        pizza.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //El �ngulo que tom� en la linea anterior lo usa para rotar el sprite 

        pizza.GetComponent<Rigidbody2D>().velocity = direction * pizzaSpeed; //Dispara esa pizza hacia el lugar del click que tom� anteriormente

        lastShoot = Time.time; //Guarda el momento en el que se dispara como �ltimo disparo para el cooldown
    }
}