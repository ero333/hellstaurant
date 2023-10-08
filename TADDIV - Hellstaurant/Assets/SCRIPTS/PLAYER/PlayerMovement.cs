using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float speed = 3f;  // Velocidad del personaje
    [SerializeField] public float speedWithPowerUp = 7f;  // Velocidad del personaje con el power-up de la pizza picante

    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;

    public bool isHealing = false;

    public static PlayerMovement instance;

    public AudioSource Coinsound;

    public AudioSource Pickupsound;


    public void Awake()
    {
        instance = this; 
    }
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>(); //para el animator
        isHealing = false;
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal") + Input.GetAxisRaw("DpadHorizontal"); // Teclas A y D
        float moveY = Input.GetAxisRaw("Vertical") + Input.GetAxisRaw("DpadVertical");   // Teclas W y S
        moveInput = new Vector2(moveX, moveY).normalized; // que no se mueva mas rapido al ir en diagonal

        RotarSprite();
    }

    private void FixedUpdate()
    {
        if (!isHealing)
        {
            playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
        }
        else
        {
            playerRb.velocity = Vector2.zero; // Que no se mueva el player mientras se cura
        }
    }


    public void RotarSprite()   // Agregar RotarSprite();  en el Update para que funcione
    {
        SpriteRenderer playerSprite;
        playerSprite = GetComponent<SpriteRenderer>();  // para el Sprite Renderer

        if (Input.GetAxisRaw("Horizontal") + Input.GetAxisRaw("DpadHorizontal") > 0)         // Si es positivo
        {
            playerSprite.flipX = false;                 // Dejo de voltear sprite
        }
        else if (Input.GetAxisRaw("Horizontal") + Input.GetAxisRaw("DpadVertical") < 0)    //  Si es negativo
        {
            playerSprite.flipX = true;                  // Volteo Sprite
        }



        //  Si presiono el Input Horizontal (Sin importar que sea positivo o negativo) activa animación de moverse
        playerAnimator.SetBool("Caminar", Input.GetButton("Horizontal")||Input.GetButton("Vertical"));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Collectible"))
        {
            Coinsound.Play();
        }

        if(collision.CompareTag("FugaPickup"))
        {
            Pickupsound.Play();
        }

        if(collision.CompareTag("FainaPickup"))
        {
            Pickupsound.Play();
        }

        if(collision.CompareTag("PicantePickup"))
        {
            Pickupsound.Play();
        }

        if(collision.CompareTag("CajaPickup"))
        {
            Pickupsound.Play();
        }
    }

   
}