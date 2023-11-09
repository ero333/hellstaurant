using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


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
    
    public float invincibleCounter = 0f;
    public bool isInvincible = false;

    public AnimatorOverrideController frenzymode;
    public RuntimeAnimatorController normal;
    public Animator anim;

    public GameObject timeBarScript;
    public PowerUpTime PUTime;

    public GameObject potenciadorActivo;

    public bool is_using_mouse;

    public bool is_using_gamepad;

    public GameObject enemyPrefab; // El prefab del enemigo que quieres instanciar
    public Transform spawnPoint;


    private bool canShoot = true;

    public PlayerHealthController playerHealthController;

    public AnimatorOverrideController girlfrenzymode;

    public string skinName;

    public AOEDamage aoedamage;


    public void Start()
    {
        invincibleCounter = 5f; // 5 segundos de invencibilidad pizza picante 
        anim = GetComponent<Animator>();
        normal = anim.runtimeAnimatorController;

        playerHealthController = GetComponent<PlayerHealthController>();

        skinName = PlayerPrefs.GetString("skin seleccionada");

        aoedamage = CajaPrefab.GetComponent<AOEDamage>();

    }

    private Vector3 PlayerPosition()
    {
        // Puedes ajustar esta función para obtener la posición actual del jugador.
        // Por ejemplo, si el jugador tiene un script "PlayerController", podrías acceder a su posición desde allí.
        // Asumiendo que el jugador tiene el tag "Player", podrías hacer lo siguiente:
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            return player.transform.position;
        }
        else
        {
            // Si no se encuentra al jugador, simplemente regresa el origen.
            return Vector3.zero;
        }
    }

    private void Update()
    {
        if (isInvincible)
        {
            invincibleCounter -= Time.deltaTime;

            if (invincibleCounter <= 0)
            {
                isInvincible = false;
            }
        }
        
        if (Input.GetMouseButtonDown(0)) {
            is_using_mouse = true;
            is_using_gamepad = false;
        }
        else if (Input.GetKey("up") || Input.GetKey("joystick button 0") || Input.GetKey("down") || Input.GetKey("joystick button 1") || Input.GetKey("left") || Input.GetKey("joystick button 2") || Input.GetKey("right") || Input.GetKey("joystick button 3") ) {
            is_using_mouse = false;
            is_using_gamepad = false;
        }
        else if (Mathf.Abs(Input.GetAxisRaw("ShootHorizontal") + Input.GetAxisRaw("ShootVertical")) > 0.5) {
            is_using_gamepad = true;
            is_using_mouse = false;
        }

        //DEBUG
        //Debug.Log("isHealing: " + isHealing);

        // Evita que el jugador dispare mientras se est� curando
        if (playerHealthController.isHealing == false)
        {
            if (canShoot && ((Mathf.Abs(Input.GetAxisRaw("ShootHorizontal") + Input.GetAxisRaw("ShootVertical")) > 0.5) || Input.GetMouseButtonDown(0) || Input.GetKey("up") || Input.GetKey("down") || Input.GetKey("right")|| Input.GetKey("left") || Input.GetKey("joystick button 0") || Input.GetKey("joystick button 1") || Input.GetKey("joystick button 2") || Input.GetKey("joystick button 3")) && Time.time - lastShoot >= cooldown)
            {
                Debug.Log("Shooting");

                // Establecemos la direccion de disparo
                Vector3 direction = new Vector3(0,0,0);

                // Obtenemos las coordenadas del rat�n en la pantalla
                Vector3 mousePositionScreen = Mouse.current.position.ReadValue();

                // Establecemos la distancia de la c�mara al plano del mundo del juego
                float distanceToCamera = 10f; // Ajusta esto seg�n tu configuraci�n

                // Convertimos las coordenadas del rat�n en el mundo del juego
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePositionScreen.x, mousePositionScreen.y, distanceToCamera));

                // Calculamos la direcci�n hacia la que debe disparar
                if (is_using_mouse)
                {
                    direction = (mousePosition - shootPoint.transform.position).normalized;
                    Debug.Log("mouse");
                }

                else if (is_using_gamepad)
                {
                    direction = new Vector3(Input.GetAxisRaw("ShootHorizontal"), -Input.GetAxisRaw("ShootVertical"), 0).normalized;
                    Debug.Log(direction);
                }

                else
                {
                    Debug.Log("flechas");
                    if (Input.GetKey("up") || Input.GetKey("joystick button 3")){
                        direction += new Vector3(0,1,0);
                    }
                    else if (Input.GetKey("down") || Input.GetKey("joystick button 0")){
                        direction += new Vector3(0,-1,0);
                    }

                    if (Input.GetKey("left") || Input.GetKey("joystick button 2")){
                        direction += new Vector3(-1,0,0);
                    }
                    else if (Input.GetKey("right") || Input.GetKey("joystick button 1")){
                        direction += new Vector3(1,0,0);
                    }
                }

                

                pizzaShoot(direction);
            }
        }

        if (Fugazzetta || Caja || Faina)
        {
            //anim.runtimeAnimatorController = normal as RuntimeAnimatorController;

            Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), false);
            isInvincible = false;

            // Restaurar velocidad normal del jugador inmediatamente
            playerMovement.speed = 4f; // Cambia velocidad
        }
    }


    public void pizzaShoot(Vector3 direction)
    {
        anim.SetBool("shooting", true);

        if (Fugazzetta)
        {
            GameObject fugazzetta = Instantiate(FugaPrefab, shootPoint.position, Quaternion.identity);
            float angle2 = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            fugazzetta.transform.rotation = Quaternion.AngleAxis(angle2, Vector3.forward.normalized);
            fugazzetta.GetComponent<Rigidbody2D>().velocity = direction.normalized * FugazzettaSpeed;
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
            cooldown = 0.5f;
            
        }

        if (Fugazzetta == false && Faina == false && Picante == false && Caja == false)
        {
            GameObject pizza = Instantiate(pizzaPrefab, shootPoint.position, Quaternion.identity);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            pizza.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward.normalized);
            pizza.GetComponent<Rigidbody2D>().velocity = direction.normalized * pizzaSpeed;
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

            StopCoroutine(fuggazzettaPowerUp());
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
        powerUpTime = 10f;

        if (potenciadorActivo != null)
        {
            powerUpTime = 10f;
            PUTime.resetClock();
        }


        potenciadorActivo = FugaPrefab;


        Faina = false;
        Picante = false;
        Caja = false;
        Fugazzetta = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionpicante.SetActive(false);
        UIControl.cajapizza.SetActive(false);
        UIControl.porcionfaina.SetActive(false);
        UIControl.porcionfuga.SetActive(true);

        timeBarScript.SetActive(true);

        PUTime.tiempoEnMarcha = true;

        yield return null;

    }

    IEnumerator fainaPowerUp()
    {

        powerUpTime = 10f;

        if (potenciadorActivo != null)
        {
            powerUpTime = 10f;
            PUTime.resetClock();
        }


        potenciadorActivo = FainaPrefab;

        Fugazzetta = false;
        Picante = false;
        Caja = false;
        Faina = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionpicante.SetActive(false);
        UIControl.cajapizza.SetActive(false);
        UIControl.porcionfaina.SetActive(true);
        UIControl.porcionfuga.SetActive(false);

        timeBarScript.SetActive(true);

        PUTime.tiempoEnMarcha = true;

        yield return null;
    }

    IEnumerator cajaPowerUp()
    {
        powerUpTime = 10f;

        if (potenciadorActivo != null)
        {
            powerUpTime = 10f;
            PUTime.resetClock();
        }


        potenciadorActivo = CajaPrefab;

        Fugazzetta = false;
        Picante = false;
        Faina = false;
        Caja = true;
        UIControl.icono.SetActive(true);
        UIControl.porcionpicante.SetActive(false);
        UIControl.cajapizza.SetActive(true);
        UIControl.porcionfaina.SetActive(false);
        UIControl.porcionfuga.SetActive(false);

        timeBarScript.SetActive(true);

        PUTime.tiempoEnMarcha = true;

        yield return null;
    }

    IEnumerator picantePowerUp()
    {

        if (potenciadorActivo != null)
        {
            powerUpTime = 10f;
            PUTime.resetClock();
        }


        potenciadorActivo = PicantePrefab;

       Faina = false;
       Fugazzetta = false;
       Caja = false; 
       Picante = true;
       UIControl.icono.SetActive(true);
       UIControl.porcionpicante.SetActive(true);
        UIControl.cajapizza.SetActive(false);
        UIControl.porcionfaina.SetActive(false);
        UIControl.porcionfuga.SetActive(false);

        timeBarScript.SetActive(true);

        
        anim.runtimeAnimatorController = frenzymode as RuntimeAnimatorController;

        PUTime.tiempoEnMarcha = true;

        // Aumentar la velocidad del jugador con el power-up
        playerMovement.speed = 7f;

       // Ignorar colisiones con enemigos 
       Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Enemy"), true);
       isInvincible = true;

        yield return null;
    }




    public void stopShooting()
    {
        anim.SetBool("shooting", false);
    }
    public void stopShooting2()
    {
        anim.SetBool("shooting", false);
    }

}
