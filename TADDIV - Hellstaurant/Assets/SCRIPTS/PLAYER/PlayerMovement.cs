using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;  // Velocidad del personaje

    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;

    public bool isHealing = false;

    public static PlayerMovement instance;


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
        float moveX = Input.GetAxisRaw("Horizontal"); // Teclas A y D
        float moveY = Input.GetAxisRaw("Vertical");   // Teclas W y S
        moveInput = new Vector2(moveX, moveY).normalized; // que no se mueva mas rapido al ir en diagonal

        RotarSprite();
    }

    private void FixedUpdate()
    {

        if (!isHealing)
        {
            playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
        }    
        

    }


    public void RotarSprite()   // Agregar RotarSprite();  en el Update para que funcione
    {
        SpriteRenderer playerSprite;
        playerSprite = GetComponent<SpriteRenderer>();  // para el Sprite Renderer

        if (Input.GetAxisRaw("Horizontal") > 0)         // Si es positivo
        {
            playerSprite.flipX = false;                 // Dejo de voltear sprite
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)    //  Si es negativo
        {
            playerSprite.flipX = true;                  // Volteo Sprite
        }



        //  Si presiono el Input Horizontal (Sin importar que sea positivo o negativo) activa animación de moverse
        playerAnimator.SetBool("Caminar", Input.GetButton("Horizontal")||Input.GetButton("Vertical"));

    }

    
}