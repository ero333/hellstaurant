using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    
    public float lifetime = 3f;
    

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime); //Destruye la pizza después del tiempo que asignemos
    }


}
