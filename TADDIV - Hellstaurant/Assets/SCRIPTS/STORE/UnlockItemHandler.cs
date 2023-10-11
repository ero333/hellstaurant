using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UnlockItemHandler : MonoBehaviour
{
    [SerializeField] Button[] buttons;

    public int UnlockedItemsNumber;

    public coinData coindata;

    public int monedasactuales;

    public Button fugabutton;

    public Button fainabutton;

    public Button cajabutton;

    public Button frenzybutton;



    public GameObject blockFuga;
    public GameObject blockFaina;
    public GameObject blockFrenzy;
    public GameObject blockCaja;

    public GameObject Vendido1;
    public GameObject Vendido2;
    public GameObject Vendido3;
    public GameObject Vendido4;

    public int lastlevel;

    public int order = 0;



    private void Start()
    {
        order = PlayerPrefs.GetInt("ordenDePotenciador");

        lastlevel = PlayerPrefs.GetInt("UltimoNivelAlcanzado");

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");


        //PlayerPrefs.SetInt("itemsUnlocked", 0);
        

        UnlockedItemsNumber = PlayerPrefs.GetInt("itemsUnlocked");

        Vendido1.SetActive(false);
        Vendido2.SetActive(false);
        Vendido3.SetActive(false);
        Vendido4.SetActive(false);

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

            fugabutton.interactable=false;

        }

        if (PlayerPrefs.GetInt("FainaUnlocked") == 1)
        {

            fainabutton.interactable = false;

        }

        if (PlayerPrefs.GetInt("CajaUnlocked") == 1)
        {

            cajabutton.interactable = false;


        }

        if (PlayerPrefs.GetInt("FrenzyUnlocked") == 1)
        {

            frenzybutton.interactable = false;

        }

        if (PlayerPrefs.GetInt("FugazzettaUnlocked") == 1)
        {
            Vendido2.SetActive(true);
            
        }

        if (PlayerPrefs.GetInt("FainaUnlocked") == 1)
        {
            Vendido3.SetActive(true);
        }

        if (PlayerPrefs.GetInt("CajaUnlocked") == 1)
        {
            Vendido1.SetActive(true);
        }

        if (PlayerPrefs.GetInt("FrenzyUnlocked") == 1)
        {
            Vendido4.SetActive(true);
        }
    }


    public void BuyFuga()
    {
        

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 70 && UnlockedItemsNumber >=1)
        {

            monedasactuales = monedasactuales - 70;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("FugazzettaUnlocked", 1);

            Vendido2.SetActive(true);

            order++;

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.skinSe = FUGAZZETA");
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);

            



        }
        
    }

    public void BuyFaina()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 120 && UnlockedItemsNumber >= 2)
        {

            monedasactuales = monedasactuales - 120;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FainaUnlocked", 1);

            Vendido3.SetActive(true);

            order++;

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.skinSe = FAINA");
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);

            
        }

    }
    public void BuyCaja()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 200 && UnlockedItemsNumber >= 3)
        {

            monedasactuales = monedasactuales - 200;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("CajaUnlocked", 1);

            Vendido1.SetActive(true);

            order++;

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.skinSe = CAJA");
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);

            
        }

    }

    public void BuyFrenzy()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 370 && UnlockedItemsNumber >= 4)
        {

            monedasactuales = monedasactuales - 370;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FrenzyUnlocked", 1);

            Vendido4.SetActive(true);

            order++;

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.skinSe = PICANTE");
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);

            
        }

    }


}
