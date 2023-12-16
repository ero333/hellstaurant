using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2 : MonoBehaviour
{
    //VARIABLES DE CADA CARTEL DEL TUTORIAL//
    public GameObject cartel1, cartel2, cartel3, cartel4, cartel5, cartel6, cartel7, cartel8, cartel9, cartel10, cartel11, cartel12, cartel13;

    //VARIABLE DEL BOT�N SIGUIENTE//
    public GameObject botonSaltar;

    //CONTADOR DE POR CU�L CARTEL VAS//

    public float contadorCarteles;

    

    public GameObject contadorMonedas;
    public GameObject íconoMonedas;
    public GameObject timer;
    public GameObject spawner;
    public GameObject spawner2;
    public GameObject spawner3;

    public GameObject fugaspawn;
    public GameObject fainaspawn;
    public GameObject cajaspawn;
    public GameObject picantespawn;

    public GameObject fainaspawner;
    public GameObject fugaspawner;
    public GameObject cajaspawner;
    public GameObject picantespawner;

    public bool canSpawn = true;

    public SpawnPotenciadores spawners;
    public SpawnPotenciadores spawners2;
    public SpawnPotenciadores spawners3;
    public SpawnPotenciadores spawners4;



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
            StartCoroutine(pruebaCaja());
        }

        if (contadorCarteles == 10)
        {
            cartel9.SetActive(false);
            cartel10.SetActive(true);
        }

        if (contadorCarteles == 11)
        {
           StartCoroutine (pruebaPicante());
        }

        if (contadorCarteles == 12)
        {
            cartel11.SetActive(false);
            cartel12.SetActive(true);
        }

        if (contadorCarteles == 13)
        {
            cartel12.SetActive(false);
            cartel13.SetActive(true);
        }

        //if (contadorCarteles == 8)
        //{
        //    cartel7.SetActive(false);
        //    cartel8.SetActive(true);
        //}


        //if (contadorCarteles == 9)
        //{
        //    StartCoroutine(pruebaHeal());
        //}


        if (contadorCarteles >= 14)
        {
            Time.timeScale = 1f;

           
            cartel13.SetActive(false);
            botonSaltar.SetActive(false);
            spawner.SetActive(true);
            spawner2.SetActive(true); 
            spawner3.SetActive(true);

            timer.SetActive(true);
            fainaspawner.SetActive(true);
            fugaspawner.SetActive(true);
            picantespawner.SetActive(true);
            cajaspawner.SetActive(true);
            contadorMonedas.SetActive(true);
            íconoMonedas.SetActive(true);

            spawners.startSpawning();
            spawners2.startSpawning();
            spawners3.startSpawning();
            spawners4.startSpawning();

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

    IEnumerator pruebaCaja()
    {

        Time.timeScale = 1f;


        cartel8.SetActive(false);
        botonSaltar.SetActive(false);
        //spawner.SetActive(true);

        cajaspawn.SetActive(true);
        contadorMonedas.SetActive(true);
        íconoMonedas.SetActive(true);

        yield return new WaitForSeconds(12f);



        //spawner.SetActive(false);
        //contadorCarteles++;
        Time.timeScale = 0f;



        botonSaltar.SetActive(true);
        cartel9.SetActive(true);

    }

    IEnumerator pruebaPicante()
    {

        Time.timeScale = 1f;


        cartel10.SetActive(false);
        botonSaltar.SetActive(false);
        //spawner.SetActive(true);

        picantespawn.SetActive(true);
        contadorMonedas.SetActive(true);
        íconoMonedas.SetActive(true);

        yield return new WaitForSeconds(14f);



        //spawner.SetActive(false);
        //contadorCarteles++;
        Time.timeScale = 0f;



        botonSaltar.SetActive(true);
        cartel11.SetActive(true);

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
