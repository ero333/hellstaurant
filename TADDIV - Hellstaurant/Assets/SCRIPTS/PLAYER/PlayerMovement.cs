using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;  // Velocidad del personaje

    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;

    public float KBForce; // fuerza del knockback
    public float KBCounter; // cuanto tiempo queda del efecto
    public float KBTotalTime; // cuanto dura el efecto en total

    public bool KnockFromRight; // marca la direcion del knockback
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>(); //para el animator
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Teclas A y D
        float moveY = Input.GetAxisRaw("Vertical");   // Teclas W y S
        moveInput = new Vector2(moveX, moveY).normalized; // que no se mueva mas rapido al ir en diagonal

        // playerAnimator.SetFloat("Horizontal", moveX); //movimiento diagonal, variables float animator
        // playerAnimator.SetFloat("Vertical", moveY);
        // playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);

        RotarSprite();
    }

    private void FixedUpdate()
    {
        if(KBCounter <= 0) // instancia en la cual si no hay knockback, el jugador se puede mover
        {
            playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
        }  
        else
        {
            if (KnockFromRight == true) // si lo atacan por la derecha
            {
                playerRb.velocity = new Vector2(-KBForce, KBForce); // se mueve para la izquierda (negativo)
            }
            if (KnockFromRight == false) 
            {
                playerRb.velocity = new Vector2(KBForce, KBForce); // se mueve a la derecha
            }

            KBCounter -= Time.deltaTime; // para que el knockback no sea eterno y termine

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



        //  Si presiono el Input Horizontal (Sin importar que sea positivo o negativo) activa animaciÃ³n de moverse
        playerAnimator.SetBool("Caminar", Input.GetButton("Horizontal")||Input.GetButton("Vertical"));

    }
}