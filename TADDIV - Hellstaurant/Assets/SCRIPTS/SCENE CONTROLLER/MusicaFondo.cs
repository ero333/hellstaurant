using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaFondo : MonoBehaviour
{
    static MusicaFondo variable;
    public AudioSource bg;

    void Awake()
    {
        bg.Play();
        if (variable != null)
        {
            Destroy(this.gameObject);
        }

        else
        {
            variable = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }


}


