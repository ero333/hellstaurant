using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteFind : MonoBehaviour
{

    public Mutear mutescript;

    public Button botonmutear;

    public Sprite spriteMuteado;

    public Sprite spriteDesmuteado;


    // Start is called before the first frame update
    void Start()
    {
        mutescript = GameObject.FindGameObjectWithTag ("musicAlterner").GetComponent<Mutear>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mutescript.Muteado)
        {
            if (botonmutear != null)
            {
                Image imagenBoton = botonmutear.GetComponent<Image>();

                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteMuteado;
                }

            }
        }



        if (mutescript.Muteado == false)
        {
            if (botonmutear != null)
            {
                Image imagenBoton = botonmutear.GetComponent<Image>();

                if (imagenBoton != null)
                {
                    imagenBoton.sprite = spriteDesmuteado;
                }

            }
        }

    }


    public void mutearSonido()
    {
        mutescript.Mutearr();
    }
}
