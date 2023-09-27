using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkin : MonoBehaviour
{

    public AnimatorOverrideController girlSkin;
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

        if (skinName == "girlSkin")
        {
            girlSkinchange();
        }

    }

    public void girlSkinchange()
    {
        anim.runtimeAnimatorController = girlSkin as RuntimeAnimatorController;
    }

    public void manSkinchange()
    {
        anim.runtimeAnimatorController = defaultSkin as RuntimeAnimatorController;
    }


}
