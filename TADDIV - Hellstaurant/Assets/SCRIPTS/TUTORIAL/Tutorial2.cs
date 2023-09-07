using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    //VARIABLES DE CADA CARTEL DEL TUTORIAL//
    public GameObject cartel1, cartel2, cartel3, cartel4, cartel5, cartel6, cartel7, cartel8;

    //VARIABLE DEL BOTÓN SIGUIENTE//
    public GameObject botonSaltar;

    //CONTADOR DE POR CUÁL CARTEL VAS//

    public float contadorCarteles;



    public GameObject contadorMonedas;
    public GameObject íconoMonedas;
    public GameObject timer;
    public GameObject spawner;

    public float spawnRate = 1f; //potenciadores

    public GameObject[] PowerUp;

    public bool canSpawn = true;


    void Start()
    {
        contadorCarteles = 0;
        Time.timeScale = 0f;
        cartel1.SetActive(true);
    }


    public void pasarcartel()
    {
        contadorCarteles++;

        //CADA VEZ QUE EL CONTADOR SUMA 1, SE DESACTIVA EL CARTEL ACTUAL Y SE ACTIVA EL SIGUIENTE//

        //LOS CARTELES QUE TE DEJAN JUGAR UN RATO, TIENEN CORRUTINAS ESPECIALES MÁS ABAJO//

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

            botonSaltar.SetActive(false);

            StartCoroutine(pruebaspawner());
        }
        if (contadorCarteles == 4)
        {
            cartel4.SetActive(false);
            cartel5.SetActive(true);

            botonSaltar.SetActive(false);

           
        }
        if (contadorCarteles == 5)
        {
            cartel5.SetActive(false);
            cartel6.SetActive(true);
        }

        //ESTE POR EJEMPLO TIENE UNA CORRUTINA, ENTONCES DESACTIVAMOS EL BOTÓN DE SIGUIENTE PARA PODER JUGAR TAMBIÉN, Y ACTIVAMOS LA CORRUTINA//

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

      
    }


    //LOS CARTELES QUE LLEVAN CORRUTINA SON EL 7, EL 10, EL 13//

    //PARA AGOS//
    //EN EL CARTEL 13, SE TIENEN QUE ACTIVAR DE LA JERARQUIA EL SPAWNER (LO HACES CON UN SET ACTIVE) Y DEL OBJETO "CANVAS", EL COINS Y EL CONTADOR DE MONEDAS//
    //A ESA CORRUTINA DEL CARTEL 13, LE PONES QUE ESPERE 15 SEGUNDOS EN VEZ DE 8//

    //EN EL ÚLTIMO CARTEL, ADEMÁS DE DESAPARECERLO, HACES QUE SE ACTIVE DE LA JERARQUÍA EL OBJETO DE ADVANCETIMER, ASÍ SE PUEDE JUGAR//


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

        

        yield return new WaitForSeconds(15f);


        contadorCarteles++;

        

        botonSaltar.SetActive(true);
        Time.timeScale = 0f;

    }

    IEnumerator pruebafaina()
    {
        Time.timeScale = 1f;

        spawner.SetActive(true);
        íconoMonedas.SetActive(true);
        contadorMonedas.SetActive(true);

        yield return new WaitForSeconds(15f);


        while (canSpawn)
        {
            WaitForSeconds wait = new WaitForSeconds(spawnRate);

            yield return wait;
            int rand = Random.Range(0, PowerUp.Length);
            GameObject PowerUpSp = PowerUp[rand];


            Instantiate(PowerUpSp, transform.position, Quaternion.identity);
        }

        contadorCarteles++;



        botonSaltar.SetActive(true);
        Time.timeScale = 0f;

    }



    // Update is called once per frame
    void Update()
    {

    }
}
