using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
           

            anim.runtimeAnimatorController = girlSkinFrenzy as RuntimeAnimatorController;



        }



        if (collision.CompareTag("PicantePickup") && skinName == "halloweenSkin")
        {
            

            anim.runtimeAnimatorController = halloweenSkinFrenzy as RuntimeAnimatorController;



        }


        if (collision.CompareTag("PicantePickup") && skinName == "spidermanSkin")
        {


            anim.runtimeAnimatorController = spidermanSkinFrenzy as RuntimeAnimatorController;



        }


        if (collision.CompareTag("PicantePickup") && skinName == "goldSkin")
        {


            anim.runtimeAnimatorController = doradoSkinFrenzy as RuntimeAnimatorController;



        }

        if (collision.CompareTag("PicantePickup") && skinName == "messiSkin")
        {


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

}