using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
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

    public float powerUpTime = 10f;
    public PotenciadorUIController UIControl;

    private bool tienePizzaPicante = false;
    private float invincibleCounter = 0f;
    private bool isInvincible = false;

    public void Start()
    {
        invincibleCounter = 5f;
    }

    private void Update()
    {
        if (isInvincible)
        {
            invincibleCounter -= Time.deltaTime;

            if (invincibleCounter <= 0)
            {
                isInvincible = false;
                Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
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

        if (Fugazzetta == false && Faina == false && Picante == false)
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

        // Ignorar colisiones con enemigos 
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), true);
        isInvincible = true;

        yield return new WaitForSeconds(5f); // 5 segundos de invencibilidad 

        // Restaurar colisiones con enemigos 
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
        isInvincible = false;

        Picante = false;
    }
}

