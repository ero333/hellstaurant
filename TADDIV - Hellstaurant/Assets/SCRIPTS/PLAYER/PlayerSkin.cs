using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{

    public AnimatorOverrideController girlSkin;
    public AnimatorOverrideController girlSkinFrenzy;


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



    //CAMBIOS A FRENZY//


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PicantePickup") && skinName == "girlSkin" )
        {
            //StartCoroutine(GirlpicantePowerUp());

            anim.runtimeAnimatorController = girlSkinFrenzy as RuntimeAnimatorController;



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