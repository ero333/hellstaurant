using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

    public GameObject cartel1, cartel2, cartel3, cartel4, cartel5, cartel6, cartel7, cartel8,cartel9,cartel10,cartel11;

    public GameObject botonSaltar;

    public float contadorCarteles;
    // Start is called before the first frame update
    void Start()
    {
        contadorCarteles = 0;
        Time.timeScale = 0f;
        cartel1.SetActive(true);
    }


    public void pasarcartel()
    {
        contadorCarteles ++;

        if (contadorCarteles == 1)
        {
            cartel1.SetActive(false);
            cartel2.SetActive(true);
        }
        if (contadorCarteles == 2)
        {
            cartel2.SetActive(false);
            cartel3.SetActive(true);
        }
        if (contadorCarteles == 3)
        {
            cartel3.SetActive(false);
            cartel4.SetActive(true);
        }
        if (contadorCarteles == 4)
        {
            cartel4.SetActive(false);
            cartel5.SetActive(true);
        }
        if (contadorCarteles == 5)
        {
            cartel5.SetActive(false);
            cartel6.SetActive(true);
        }

        if (contadorCarteles == 6)
        {
            cartel6.SetActive(false);
            cartel7.SetActive(true);

            botonSaltar.SetActive(false);

            StartCoroutine(pruebamovimiento());
        }

        if (contadorCarteles == 7)
        {
            cartel7.SetActive(false);
            cartel8.SetActive(true);
        }

        if (contadorCarteles == 8)
        {
            cartel8.SetActive(false);
            cartel9.SetActive(true);
        }


        if (contadorCarteles == 9)
        {
            cartel9.SetActive(false);
            cartel10.SetActive(true);

            botonSaltar.SetActive(false);

            StartCoroutine(pruebadisparo());

        }

        if (contadorCarteles == 10)
        {
            cartel10.SetActive(false);
            cartel11.SetActive(true);
        }


    }




    IEnumerator pruebadisparo()
    {
        Time.timeScale = 1f;

        yield return new WaitForSeconds(8f);


        Time.timeScale = 0f;

        contadorCarteles++;
        cartel11.SetActive(true) ;
        
        botonSaltar.SetActive(true);
        

    }


    IEnumerator pruebamovimiento()
    {
        Time.timeScale = 1f;

        yield return new WaitForSeconds(8f);

        contadorCarteles++;

        cartel7.SetActive(false);
        cartel8.SetActive(true);

        botonSaltar.SetActive(true);
        Time.timeScale = 0f;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
