using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;  // Velocidad del personaje

    private Rigidbody2D playerRb;
    private Vector2 moveInput;
    private Animator playerAnimator;

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

        playerAnimator.SetFloat("Horizontal", moveX); //movimiento diagonal, variables float animator
        playerAnimator.SetFloat("Vertical", moveY);
        playerAnimator.SetFloat("Speed", moveInput.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition(playerRb.position + moveInput * speed * Time.fixedDeltaTime);
    }
}
