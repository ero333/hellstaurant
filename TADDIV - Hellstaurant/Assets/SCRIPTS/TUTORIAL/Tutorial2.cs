using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    //VARIABLES DE CADA CARTEL DEL TUTORIAL//
    public GameObject cartel1, cartel2, cartel3, cartel4, cartel5, cartel6, cartel7, cartel8, cartel9, cartel10;

    //VARIABLE DEL BOTÓN SIGUIENTE//
    public GameObject botonSaltar;

    //CONTADOR DE POR CUÁL CARTEL VAS//

    public float contadorCarteles;

    

    public GameObject contadorMonedas;
    public GameObject íconoMonedas;
    public GameObject timer;
    public GameObject spawner;

    public GameObject fugaspawn;
    public GameObject fainaspawn;

    public GameObject fainaspawner;
    public GameObject fugaspawner;

    public bool canSpawn = true;

    public SpawnPotenciadores spawners;
    public SpawnPotenciadores spawners2;



    void Start()
    {
        contadorCarteles = 0;
        Time.timeScale = 0f;
        cartel1.SetActive(true);
        fainaspawn.SetActive(false);
    }


    public void pasarcartel()
    {
        contadorCarteles++;

        if (contadorCarteles == 1)
        {
            cartel1.SetActive (false);
            cartel2.SetActive (true);
        }

        if (contadorCarteles == 2)
        {
            cartel2.SetActive(false);
            cartel3.SetActive(true);
        }

        if (contadorCarteles == 3)
        {
            StartCoroutine(pruebaFuga());
        }

        if (contadorCarteles == 4)
        {
            cartel3.SetActive(false);
            cartel4.SetActive(true);
        }

        if (contadorCarteles == 5)
        {
            cartel4.SetActive(false);
            cartel5.SetActive(true);
        }

        if (contadorCarteles == 6)
        {
            StartCoroutine(pruebaFaina());
        }


        if (contadorCarteles == 7)
        {
            cartel6.SetActive(false);
            cartel7.SetActive(true);
        }

        if (contadorCarteles == 8)
        {
            cartel7.SetActive(false);
            cartel8.SetActive(true);
        }


        if (contadorCarteles == 9)
        {
            StartCoroutine(pruebaHeal());
        }


        if (contadorCarteles >= 10)
        {
            Time.timeScale = 1f;

           
            cartel9.SetActive(false);
            botonSaltar.SetActive(false);
            //spawner.SetActive(true);

            timer.SetActive(true);
            fainaspawner.SetActive(true);
            fugaspawner.SetActive(true);
            contadorMonedas.SetActive(true);
            íconoMonedas.SetActive(true);

            spawners.startSpawning();
            spawners2.startSpawning();

        }


    }


    IEnumerator pruebaFuga()
    {
        Time.timeScale = 1f;
        cartel3.SetActive(false);
        botonSaltar.SetActive(false);
        spawner.SetActive(true);
        fugaspawn.SetActive(true);
        contadorMonedas.SetActive(true);
        íconoMonedas.SetActive(true);

        yield return new WaitForSeconds(12f);

        //spawner.SetActive(false);
        contadorCarteles++;
        Time.timeScale = 0f;

        contadorMonedas.SetActive(false);
        íconoMonedas.SetActive(false);
        botonSaltar.SetActive (true);
        cartel4.SetActive (true);
        

        
    }

    IEnumerator pruebaFaina()
    {

            Time.timeScale = 1f;

            
            cartel5.SetActive(false);
            botonSaltar.SetActive(false);
            //spawner.SetActive(true);

            fainaspawn.SetActive(true);
            contadorMonedas.SetActive(true);
            íconoMonedas.SetActive(true);

            yield return new WaitForSeconds(12f);

            
            
            //spawner.SetActive(false);
            //contadorCarteles++;
            Time.timeScale = 0f;
            

            
            botonSaltar.SetActive(true);
            cartel6.SetActive(true);



        
    }

    IEnumerator pruebaHeal()
    {
        Time.timeScale = 1f;


        cartel8.SetActive(false);
        botonSaltar.SetActive(false);
        //spawner.SetActive(true);

        //fainaspawner.SetActive(true);
        //fugaspawner.SetActive(true);    
        contadorMonedas.SetActive(true);
        íconoMonedas.SetActive(true);

        yield return new WaitForSeconds(15f);



        //spawner.SetActive(false);
        contadorCarteles++;
        Time.timeScale = 0f;



        botonSaltar.SetActive(true);
        cartel9.SetActive(true);

    }

    IEnumerator finalTest()
    {
        Time.timeScale = 1f;

        spawners.startSpawning();


        cartel9.SetActive(false);
        botonSaltar.SetActive(false);
        //spawner.SetActive(true);

        

        timer.SetActive(true);
        fainaspawner.SetActive(true);
        fugaspawner.SetActive(true);    
        contadorMonedas.SetActive(true);
        íconoMonedas.SetActive(true);

        yield return null;
    }

}
