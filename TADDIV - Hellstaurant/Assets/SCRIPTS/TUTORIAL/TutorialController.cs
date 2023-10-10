using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialController : MonoBehaviour
{

    //VARIABLES DE CADA CARTEL DEL TUTORIAL//
    public GameObject cartel1, cartel2, cartel3, cartel4, cartel5, cartel6, cartel7, cartel8, cartel9, cartel10, cartel11, cartel12, cartel13, cartel14, cartel15, cartel16, cartel17, cartel18;

    //VARIABLE DEL BOT�N SIGUIENTE//
    public GameObject botonSaltar;

    //CONTADOR DE POR CU�L CARTEL VAS//

    public float contadorCarteles;



    public GameObject contadorMonedas;
    public GameObject íconoMonedas;
    public GameObject timer;
    public GameObject spawner;
    

    void Start()
    {
        contadorCarteles = 0;
        Time.timeScale = 0f;
        cartel1.SetActive(true);
    }


    public void pasarcartel()
    {
        contadorCarteles ++;

        //CADA VEZ QUE EL CONTADOR SUMA 1, SE DESACTIVA EL CARTEL ACTUAL Y SE ACTIVA EL SIGUIENTE//

        //LOS CARTELES QUE TE DEJAN JUGAR UN RATO, TIENEN CORRUTINAS ESPECIALES M�S ABAJO//

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

        //ESTE POR EJEMPLO TIENE UNA CORRUTINA, ENTONCES DESACTIVAMOS EL BOT�N DE SIGUIENTE PARA PODER JUGAR TAMBI�N, Y ACTIVAMOS LA CORRUTINA//

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

        if (contadorCarteles == 11)
        {
            cartel11.SetActive(false);
            cartel12.SetActive(true);
        }

        if (contadorCarteles == 12)
        {
            cartel12.SetActive(false);
            cartel13.SetActive(true);

            botonSaltar.SetActive(false);

             StartCoroutine(pruebaspawner());
        }

        if (contadorCarteles == 13)
        {
            cartel14.SetActive(false);
            cartel15.SetActive(true);
        }

        if (contadorCarteles == 14)
        {
            cartel14.SetActive(false);
            cartel15.SetActive(true);
        }

        if (contadorCarteles == 15)
        {
            cartel15.SetActive(false);
            cartel16.SetActive(true);
        }

        if (contadorCarteles == 16)
        {
            cartel16.SetActive(false);
            cartel17.SetActive(true);
        }

        if (contadorCarteles == 17)
        {
            cartel17.SetActive(false);
            cartel18.SetActive(true);
        }

        if (contadorCarteles == 18)
        {
            cartel18.SetActive(false);
            timer.SetActive(true);
            Time.timeScale = 1.0f;
            botonSaltar.SetActive(false);
            
        }
    }


    //LOS CARTELES QUE LLEVAN CORRUTINA SON EL 7, EL 10, EL 13//

    //PARA AGOS//
    //EN EL CARTEL 13, SE TIENEN QUE ACTIVAR DE LA JERARQUIA EL SPAWNER (LO HACES CON UN SET ACTIVE) Y DEL OBJETO "CANVAS", EL COINS Y EL CONTADOR DE MONEDAS//
    //A ESA CORRUTINA DEL CARTEL 13, LE PONES QUE ESPERE 15 SEGUNDOS EN VEZ DE 8//

    //EN EL �LTIMO CARTEL, ADEM�S DE DESAPARECERLO, HACES QUE SE ACTIVE DE LA JERARQU�A EL OBJETO DE ADVANCETIMER, AS� SE PUEDE JUGAR//


    IEnumerator pruebadisparo()
    {

        //CON ESTO RENAUDAMOS EL TIEMPO//
        Time.timeScale = 1f;

        //CON ESTO ESPERAMOS 8 SEGUNDOS PARA QUE EL JUGADOR PRUEBE//
        yield return new WaitForSeconds(8f);

        //PARAMOS EL TIEMPO DE NUEVO//
        Time.timeScale = 0f;

        //SUMAMOS 1 AL CONTADOR DE CARTELES//
        contadorCarteles++;

        //ACTIVAMOS EL CARTEL QUE SIGUE Y EL BOTON DE SIGUIENTE//
        cartel10.SetActive(false);
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

    
    IEnumerator pruebaspawner()
    {
        Time.timeScale = 1f;

        spawner.SetActive(true);
        íconoMonedas.SetActive(true);
        contadorMonedas.SetActive(true);

        cartel13.SetActive(false);
        cartel14.SetActive(true);

        yield return new WaitForSeconds(15f);


        contadorCarteles++;

        cartel14.SetActive(false);
        cartel15.SetActive(true);

        botonSaltar.SetActive(true);
        Time.timeScale = 0f;

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
