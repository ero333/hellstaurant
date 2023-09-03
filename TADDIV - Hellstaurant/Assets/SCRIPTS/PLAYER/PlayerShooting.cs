using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject pizzaPrefab; //Objeto de la rodaja de pizza
    public Transform shootPoint; //Punto desde el que se dispara
    public float pizzaSpeed = 10f; //Velocidad a la que se dispara

    public float cooldown = 0.5f; // Cooldown que queremos para el disparo
    private float lastShoot; // Última vez que disparaste 

    public GameObject FugaPrefab;
    public float FugazzettaSpeed = 5f;
    public bool Fugazzetta;

    public GameObject FainaPrefab;
    public float FainaSpeed = 20f;
    public bool Faina;

    public float powerUpTime = 10f;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time - lastShoot >= cooldown) //Al hacer click izquierdo y calculando que el tiempo que paso entre el último disparo y el tiempo actual sea mayor al del cooldown
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Toma la posición del click
            Vector3 direction = (mousePosition - shootPoint.position).normalized; //Compara la posición del mouse a la posición de la cuál se va a disparar

            pizzaShoot(direction);
        }


      
    }



    public void pizzaShoot(Vector3 direction)
    {
        if (Fugazzetta)
        {
            GameObject fugazzetta = Instantiate(FugaPrefab, shootPoint.position, Quaternion.identity); 

            float angle2 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

            fugazzetta.transform.rotation = Quaternion.AngleAxis(angle2, Vector3.forward); 

            fugazzetta.GetComponent<Rigidbody2D>().velocity = direction * FugazzettaSpeed; 

            lastShoot = Time.time; 
        }

        if (Faina)
        {
            GameObject faina = Instantiate(FainaPrefab, shootPoint.position, Quaternion.identity);

            float angle3 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            faina.transform.rotation = Quaternion.AngleAxis(angle3, Vector3.forward);

            faina.GetComponent<Rigidbody2D>().velocity = direction * FainaSpeed;

            lastShoot = Time.time;
        }

        if (Fugazzetta == false && Faina == false)
        {
            GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity); //Genera una pizza en el punto de disparo

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //El Atan2 sirve para calcular la tangente entre 2 números, en este caso X e Y del click del mouse. Y lo transforma en grados de un ángulo con el Rad2Deg

            pizza.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //El ángulo que tomó en la linea anterior lo usa para rotar el sprite 

            pizza.GetComponent<Rigidbody2D>().velocity = direction * pizzaSpeed; //Dispara esa pizza hacia el lugar del click que tomó anteriormente

            lastShoot = Time.time; //Guarda el momento en el que se dispara como último disparo para el cooldown
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FugaPickup"))
        {
            StartCoroutine(fuggazzettaPowerUp());
        }

        if (collision.CompareTag("FainaPickup"))
        {
            StartCoroutine(fainaPowerUp());
        }
    }

    IEnumerator fuggazzettaPowerUp()
    {
        Faina = false;
        Fugazzetta = true;
        

        yield return new WaitForSeconds(powerUpTime);

        Fugazzetta = false;
    }

    IEnumerator fainaPowerUp()
    {
        Fugazzetta = false;
        Faina = true;
        

        yield return new WaitForSeconds(powerUpTime);

        Faina = false;
    }
}