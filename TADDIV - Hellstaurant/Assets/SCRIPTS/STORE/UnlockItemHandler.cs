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

    public GameObject fainabutton;

    public GameObject cajabutton;

    public GameObject frenzybutton;



    public GameObject blockFuga;
    public GameObject blockFaina;
    public GameObject blockFrenzy;
    public GameObject blockCaja;



    private void Start()
    {

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");


        //PlayerPrefs.SetInt("itemsUnlocked", 0);
        

        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");


        if (UnlockedItemsNumber <= 0)
        {
            blockCaja.SetActive(true);
            blockFaina.SetActive(true);
            blockFrenzy.SetActive(true);
            blockFuga.SetActive(true);
        }


        //for (int i=0; i<buttons.Length; i++) {
        //buttons[i].interactable = false;
        //}
    }

    private void Update()
    {
        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");


        if ( UnlockedItemsNumber >= 1)
        {
            blockFuga.SetActive(false);
        }
        if (UnlockedItemsNumber >= 2)
        {
            blockFaina.SetActive(false);
        }
        if (UnlockedItemsNumber >= 3)
        {
            blockCaja.SetActive(false);
        }
        if (UnlockedItemsNumber >= 4)
        {
            blockFrenzy.SetActive(false);
        }


        if (Input.GetKeyDown(KeyCode.P)) {

            monedasactuales = monedasactuales + 150;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

        }


        //for (int i=0; i<buttons.Length; i++) {
        //    buttons[i].interactable = true;
        //}

        if (PlayerPrefs.GetInt("FugazzettaUnlocked") == 1)
        {

            fugabutton.SetActive(false);

        }

        if (PlayerPrefs.GetInt("FainaUnlocked") == 1)
        {

            fainabutton.SetActive(false);

        }

        if (PlayerPrefs.GetInt("CajaUnlocked") == 1)
        {

            cajabutton.SetActive(false);

        }

        if (PlayerPrefs.GetInt("FrenzyUnlocked") == 1)
        {

            frenzybutton.SetActive(false);

        }

    }


    public void BuyFuga()
    {
        

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 150 && UnlockedItemsNumber >=1)
        {

            monedasactuales = monedasactuales - 150;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("FugazzettaUnlocked", 1);



        }
        
    }

    public void BuyFaina()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 100 && UnlockedItemsNumber >= 2)
        {

            monedasactuales = monedasactuales - 100;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FainaUnlocked", 1);
        }

    }
    public void BuyCaja()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 250 && UnlockedItemsNumber >= 3)
        {

            monedasactuales = monedasactuales - 250;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("CajaUnlocked", 1);
        }

    }

    public void BuyFrenzy()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 400 && UnlockedItemsNumber >= 4)
        {

            monedasactuales = monedasactuales - 400;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FrenzyUnlocked", 1);
        }

    }


}
