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

    public GameObject FugaPrefab;
    public float FugazzettaSpeed = 8f;
    public bool Fugazzetta;

    public GameObject FainaPrefab;
    public float FainaSpeed = 20f;
    public bool Faina;

    public GameObject PicantePrefab;
    public float PicanteSpeed = 30f;
    public bool Picante;

    public float powerUpTime = 10f;
    public PotenciadorUIController UIControl;

    

    public void Start()
    {
        
    }
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
        if (Fugazzetta)
        {
            GameObject fugazzetta = Instantiate(FugaPrefab, shootPoint.position, Quaternion.identity); 

            float angle2 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

            fugazzetta.transform.rotation = Quaternion.AngleAxis(angle2, Vector3.forward); 

            fugazzetta.GetComponent<Rigidbody2D>().velocity = direction * FugazzettaSpeed; 

            lastShoot = Time.time;

            cooldown = 1f;
        }

        if (Faina)
        {
            GameObject faina = Instantiate(FainaPrefab, shootPoint.position, Quaternion.identity);

            float angle3 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            faina.transform.rotation = Quaternion.AngleAxis(angle3, Vector3.forward);

            faina.GetComponent<Rigidbody2D>().velocity = direction * FainaSpeed;

            lastShoot = Time.time;

            cooldown = 0.2f;
        }

        if (Fugazzetta == false && Faina == false)
        {
            GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity); //Genera una pizza en el punto de disparo

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //El Atan2 sirve para calcular la tangente entre 2 n�meros, en este caso X e Y del click del mouse. Y lo transforma en grados de un �ngulo con el Rad2Deg

            pizza.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward); //El �ngulo que tom� en la linea anterior lo usa para rotar el sprite 

            pizza.GetComponent<Rigidbody2D>().velocity = direction * pizzaSpeed; //Dispara esa pizza hacia el lugar del click que tom� anteriormente

            lastShoot = Time.time; //Guarda el momento en el que se dispara como �ltimo disparo para el cooldown

            cooldown = 0.5f;
        }

        if (Picante)
        {
            GameObject picante = Instantiate(PicantePrefab, shootPoint.position, Quaternion.identity);

            float angle4 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            picante.transform.rotation = Quaternion.AngleAxis(angle4, Vector3.forward);

            picante.GetComponent<Rigidbody2D>().velocity = direction * PicanteSpeed;

            lastShoot = Time.time;

            cooldown = 0.3f;
        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("FugaPickup"))
        {
            StartCoroutine(fuggazzettaPowerUp());
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("FainaPickup"))
        {
            StartCoroutine(fainaPowerUp());
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("PicantePickup"))
        {
            StartCoroutine(picantePowerUp());
            Destroy(collision.gameObject);
        }
    }

    IEnumerator fuggazzettaPowerUp()

    {

        Faina = false;
        Picante = false;
        Fugazzetta = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionfuga.SetActive(true);
        UIControl.Salida();
        yield return new WaitForSeconds(powerUpTime);

        

        Fugazzetta = false;
 
    }

    IEnumerator fainaPowerUp()
    {
        Fugazzetta = false;
        Picante = false;
        Faina = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionfaina.SetActive(true);
        UIControl.Salida();

        yield return new WaitForSeconds(powerUpTime);

        

        Faina = false;
    }

    IEnumerator picantePowerUp()

    {

        Faina = false;
        Fugazzetta = false;
        Picante = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionpicante.SetActive(true);
        UIControl.Salida();
        yield return new WaitForSeconds(powerUpTime);



        Picante = false;

    }
}