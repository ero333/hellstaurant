using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public PlayerMovement playerMovement; //Referecia al player movement

    public float speedWithPowerUp = 7f; //Velocidad pizza picante

    public GameObject pizzaPrefab;
    public Transform shootPoint;
    public float pizzaSpeed = 10f;
    public float cooldown = 0.5f;
    private float lastShoot;

    public GameObject FugaPrefab;
    public float FugazzettaSpeed = 8f;
    public bool Fugazzetta;

    public GameObject FainaPrefab;
    public float FainaSpeed = 20f;
    public bool Faina;

    public GameObject PicantePrefab;
    public float PicanteSpeed = 30f;
    public bool Picante;

    public GameObject CajaPrefab;
    public float CajaSpeed = 6f;
    public bool Caja;

    public float powerUpTime = 10f;
    public PotenciadorUIController UIControl;
    
    private float invincibleCounter = 0f;
    private bool isInvincible = false;

    public void Start()
    {
        invincibleCounter = 5f; // 5 segundos de invencibilidad pizza picante 
    }

    private void Update()
    {
        if (isInvincible)
        {
            invincibleCounter -= Time.deltaTime;

            if (invincibleCounter <= 0)
            {
                isInvincible = false;
                //Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
            }
        }

        if (Input.GetMouseButtonDown(0) && Time.time - lastShoot >= cooldown)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = (mousePosition - shootPoint.position).normalized;
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

        if (Fugazzetta == false && Faina == false && Picante == false && Caja == false)
        {
            GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            pizza.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            pizza.GetComponent<Rigidbody2D>().velocity = direction * pizzaSpeed;
            lastShoot = Time.time;
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

        if (Caja)
        {
            GameObject caja = Instantiate(CajaPrefab, shootPoint.position, Quaternion.identity);
            float angle5 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            caja.transform.rotation = Quaternion.AngleAxis(angle5, Vector3.forward);
            caja.GetComponent<Rigidbody2D>().velocity = direction * CajaSpeed;
            lastShoot = Time.time;
            cooldown = 1.5f;
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
        if (collision.CompareTag("CajaPickup"))
        {
            StartCoroutine(cajaPowerUp());
            Destroy(collision.gameObject);
        }
    }

    IEnumerator fuggazzettaPowerUp()
    {
        Faina = false;
        Picante = false;
        Caja = false;
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
        Caja = false;
        Faina = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionfaina.SetActive(true);
        UIControl.Salida();

        yield return new WaitForSeconds(powerUpTime);

        Faina = false;
    }

    IEnumerator cajaPowerUp()
    {
        Fugazzetta = false;
        Picante = false;
        Faina = false;
        Caja = true;
        UIControl.icono.SetActive(true);
        UIControl.tirarcaja.SetActive(true);
        UIControl.Salida();

        yield return new WaitForSeconds(powerUpTime);

        Caja = false;
    }

    IEnumerator picantePowerUp()
    {
       Faina = false;
       Fugazzetta = false;
       Caja = false; 
       Picante = true;
       UIControl.icono.SetActive(true);
       UIControl.porcionpicante.SetActive(true);
       UIControl.Salida();

       // Aumentar la velocidad del jugador con el power-up
       playerMovement.speed = 7f;

       // Ignorar colisiones con enemigos 
       Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), true);
       isInvincible = true;

       // Restaurar colisiones con enemigos y restablecer isInvincible después de un tiempo
       yield return new WaitForSeconds(powerUpTime);

       Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
       isInvincible = false;

       // Restaurar velocidad normal del jugador inmediatamente
       playerMovement.speed = 4f; // Cambia velocidad
       Picante = false;
    }
}
