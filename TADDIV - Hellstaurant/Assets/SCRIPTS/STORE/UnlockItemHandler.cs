using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockItemHandler : MonoBehaviour
{
    [SerializeField] Button[] buttons;

    public int UnlockedItemsNumber;

    public coinData coindata;

    public int monedasactuales;

    public GameObject fugabutton;

    

    private void Start()
    {

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");


        //PlayerPrefs.SetInt("itemsUnlocked", 0);
        

        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");


        //for (int i=0; i<buttons.Length; i++) {
        //buttons[i].interactable = false;
        //}
    }

    private void Update()
    {
        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");

        //for (int i=0; i<buttons.Length; i++) {
        //    buttons[i].interactable = true;
        //}

        if (PlayerPrefs.GetInt("FugazzettaUnlocked") == 1)
        {

            fugabutton.SetActive(false);

        }
    }


    public void BuyFuga()
    {
        

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 1 && UnlockedItemsNumber >=1)
        {

            monedasactuales = monedasactuales - 20;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("FugazzettaUnlocked", 1);



        }
        
    }

    public void BuyFaina()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 2 && PlayerPrefs.GetInt ("ItemsUnlocked") >=2)
        {

            monedasactuales = monedasactuales - 5;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FainaUnlocked", 1);
        }

    }

}
