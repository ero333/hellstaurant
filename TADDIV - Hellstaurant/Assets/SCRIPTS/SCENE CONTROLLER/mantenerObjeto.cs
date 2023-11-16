using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mantenerObjeto : MonoBehaviour
{

    private static mantenerObjeto instance;

    public static string identificadorUnico = "MantenerObjeto";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}


