using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolloScript : MonoBehaviour
{

    private Vector2 MoveDirection;

    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(MoveDirection * moveSpeed * Time.deltaTime);
    }

    public void OnEnable()
    {
        Invoke("Destroy", 3f);
    }

    public void setMoveDirection(Vector2 dir)
    {
        MoveDirection = dir;
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }

    public void OnDisable()
    {
        
        CancelInvoke();
        
    }
}
