using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodeteBullet : MonoBehaviour
{

    public float lifetime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime); //Destruye la pizza después del tiempo que asignemos

        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Enemy"), LayerMask.NameToLayer("muebles"), true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")){

            Destroy(this.gameObject);

        }

        
    }
}
