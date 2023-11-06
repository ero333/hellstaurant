using System.Collections;
using System.Collections.Generic;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerSkin : MonoBehaviour
{

    public AnimatorOverrideController girlSkin;
    public AnimatorOverrideController girlSkinFrenzy;

    public AnimatorOverrideController halloweenSkin;
    public AnimatorOverrideController halloweenSkinFrenzy;

    public AnimatorOverrideController spidermanSkin;
    public AnimatorOverrideController spidermanSkinFrenzy;

    public AnimatorOverrideController messiSkin;
    public AnimatorOverrideController messiSkinFrenzy;


    public AnimatorOverrideController doradoSkin;
    public AnimatorOverrideController doradoSkinFrenzy;



    public RuntimeAnimatorController defaultSkin;
    public Animator anim;

    public string skinName;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        defaultSkin = anim.runtimeAnimatorController;

        skinName = PlayerPrefs.GetString("skin seleccionada");

        if (skinName == "girlSkin")
        {
            girlSkinchange();
        }

        if (skinName == "manSkin")
        {
            manSkinchange();
        }

        if (skinName == "halloweenSkin")
        {
            halloweenSkinchange();
        }

        if (skinName == "spidermanSkin")
        {
            spidermanSkinchange();
        }

        if (skinName == "goldSkin")
        {
            doradoSkinchange();
        }

        if (skinName == "messiSkin")
        {
            messiSkinchange();
        }

    }

    // Update is called once per frame
    void Update()
    {

        

    }

    public void girlSkinchange()
    {
        anim.runtimeAnimatorController = girlSkin as RuntimeAnimatorController;
    }

    public void manSkinchange()
    {
        anim.runtimeAnimatorController = defaultSkin as RuntimeAnimatorController;
    }

    public void halloweenSkinchange()
    {
        anim.runtimeAnimatorController = halloweenSkin as RuntimeAnimatorController;
    }

    public void spidermanSkinchange()
    {
        anim.runtimeAnimatorController = spidermanSkin as RuntimeAnimatorController;
    }

    public void messiSkinchange()
    {
        anim.runtimeAnimatorController = messiSkin as RuntimeAnimatorController;
    }


    public void doradoSkinchange()
    {
        anim.runtimeAnimatorController = doradoSkin as RuntimeAnimatorController;
    }



    //CAMBIOS A FRENZY//


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PicantePickup") && skinName == "girlSkin" )
        {

            //StartCoroutine(GirlpicantePowerUp());
            anim.runtimeAnimatorController = girlSkinFrenzy as RuntimeAnimatorController;



        }



        if (collision.CompareTag("PicantePickup") && skinName == "halloweenSkin")
        {

            //StartCoroutine(HalloweenpicantePowerUp());
            anim.runtimeAnimatorController = halloweenSkinFrenzy as RuntimeAnimatorController;



        }


        if (collision.CompareTag("PicantePickup") && skinName == "spidermanSkin")
        {

            //StartCoroutine(SpidermanpicantePowerUp());
           anim.runtimeAnimatorController = spidermanSkinFrenzy as RuntimeAnimatorController;



        }


        if (collision.CompareTag("PicantePickup") && skinName == "goldSkin")
        {

            //StartCoroutine(DoradopicantePowerUp());
            anim.runtimeAnimatorController = doradoSkinFrenzy as RuntimeAnimatorController;



        }

        if (collision.CompareTag("PicantePickup") && skinName == "messiSkin")
        {

            //StartCoroutine(MessipicantePowerUp());
            anim.runtimeAnimatorController = messiSkinFrenzy as RuntimeAnimatorController;



        }

    }

    IEnumerator GirlpicantePowerUp()
    {
        anim.runtimeAnimatorController = girlSkinFrenzy as RuntimeAnimatorController;

        Debug.Log("girlFrenzy");

        yield return new WaitForSeconds(10f);
        anim.runtimeAnimatorController = girlSkin as RuntimeAnimatorController;
    }

    IEnumerator HalloweenpicantePowerUp()
    {
        anim.runtimeAnimatorController = halloweenSkinFrenzy as RuntimeAnimatorController;

        Debug.Log("halloweenFrenzy");

        yield return new WaitForSeconds(10f);
        anim.runtimeAnimatorController = halloweenSkin as RuntimeAnimatorController;
    }

    IEnumerator SpidermanpicantePowerUp()
    {
        anim.runtimeAnimatorController = spidermanSkinFrenzy as RuntimeAnimatorController;

        Debug.Log("SpidermanFrenzy");

        yield return new WaitForSeconds(10f);
        anim.runtimeAnimatorController = spidermanSkin as RuntimeAnimatorController;
    }

    IEnumerator DoradopicantePowerUp()
    {
        anim.runtimeAnimatorController = doradoSkinFrenzy as RuntimeAnimatorController;

        Debug.Log("DoradoFrenzy");

        yield return new WaitForSeconds(10f);
        anim.runtimeAnimatorController = doradoSkin as RuntimeAnimatorController;
    }

    IEnumerator MessipicantePowerUp()
    {
        anim.runtimeAnimatorController = messiSkinFrenzy as RuntimeAnimatorController;

        Debug.Log("CAMPEON WACHO");

        yield return new WaitForSeconds(10f);
        anim.runtimeAnimatorController = messiSkin as RuntimeAnimatorController;
    }

}