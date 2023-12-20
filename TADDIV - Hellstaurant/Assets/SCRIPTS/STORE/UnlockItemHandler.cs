using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Analytics;
using Unity.Services.Analytics;
using static Cinemachine.DocumentationSortingAttribute;

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

    public string powerSe;

    public GameObject popupFuga;
    public GameObject popupFaina;
    public GameObject popupCaja;
    public GameObject popupPicante;

    public GameObject noMonedas;
    

    private void Start()
    {
        order = PlayerPrefs.GetInt("ordenDePotenciador");

        //lastlevel = PlayerPrefs.GetInt("UltimoNivelAlcanzado");

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



        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 4)
        {
            lastlevel = 1;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 5)
        {
            lastlevel = 2;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 6)
        {
            lastlevel = 3;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 7)
        {
            lastlevel = 4;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 9)
        {
            lastlevel = 5;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 10)
        {
            lastlevel = 6;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 11)
        {
            lastlevel = 7;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 12)
        {
            lastlevel = 8;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 13)
        {
            lastlevel = 9;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 14)
        {
            lastlevel = 10;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 15)
        {
            lastlevel = 11;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 16)
        {
            lastlevel = 12;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 17)
        {
            lastlevel = 13;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 18)
        {
            lastlevel = 14;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 20)
        {
            lastlevel = 15;
        }
        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") == 22)
        {
            lastlevel = 16;
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


        //if (Input.GetKeyDown(KeyCode.P))
        //{

        //    monedasactuales = monedasactuales + 150;


        //    PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
        //    coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

        //}

        //if (Input.GetKeyDown(KeyCode.O))
        //{
        //    PlayerPrefs.SetInt("FugazzettaUnlocked", 1);
        //    PlayerPrefs.SetInt("FainaUnlocked", 1);
        //    PlayerPrefs.SetInt("CajaUnlocked", 1);
        //    PlayerPrefs.SetInt("FrenzyUnlocked", 1);


        //}


        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }

        if (PlayerPrefs.GetInt("FugazzettaUnlocked") == 1)
        {

            fugabutton.interactable=false;
            Vendido2.SetActive(true);

        }

        if (PlayerPrefs.GetInt("FainaUnlocked") == 1)
        {

            fainabutton.interactable = false;
            Vendido3.SetActive(true);

        }

        if (PlayerPrefs.GetInt("CajaUnlocked") == 1)
        {

            cajabutton.interactable = false;
            Vendido1.SetActive(true);


        }

        if (PlayerPrefs.GetInt("FrenzyUnlocked") == 1)
        {

            frenzybutton.interactable = false;
            Vendido4.SetActive(true);

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


    public void PopupFuga()
    {
        popupFuga.SetActive(true);
    }

    public void closePopUpFuga()
    {
        popupFuga.SetActive(false);
        noMonedas.SetActive(false);
    }


    public void BuyFuga()
    {
        

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 15 && UnlockedItemsNumber >=1)
        {

            monedasactuales = monedasactuales - 15;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("FugazzettaUnlocked", 1);

            Vendido2.SetActive(true);

            order++;

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            powerSe = "FUGAZZETTA";

            Debug.Log("BuyPower.powerSe =" + powerSe);
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);


            AnalyticsService.Instance.CustomData("BuyPower", new Dictionary<string, object>
            {
            { "powerSe", powerSe },
            { "lastLevel", lastlevel },
             { "order", order }
            });

            popupFuga.SetActive(false);
            noMonedas.SetActive(false);

        }

         if (PlayerPrefs.GetInt("MonedasRecolectadas:") < 15)
        {
            StartCoroutine(timercartelito());
        }

    }

    IEnumerator timercartelito()
    {
        noMonedas.SetActive(true);
        yield return new WaitForSeconds(3f);
        noMonedas.SetActive(false);
    }

    public void PopupFaina()
    {
        popupFaina.SetActive(true);
    }

    public void closePopUpFaina()
    {
        popupFaina.SetActive(false);
        noMonedas.SetActive(false);
    }

    public void BuyFaina()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 25 && UnlockedItemsNumber >= 2)
        {

            monedasactuales = monedasactuales - 25;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FainaUnlocked", 1);

            Vendido3.SetActive(true);

            order++;

            powerSe = "FAINA";

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.powerSe =" + powerSe);
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);



            AnalyticsService.Instance.CustomData("BuyPower", new Dictionary<string, object>
            {
            { "powerSe", powerSe },
            { "lastLevel", lastlevel },
             { "order", order }
            });

            popupFaina.SetActive(false);
            noMonedas.SetActive(false);

        }

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") < 25)
        {
            StartCoroutine(timercartelito());
        }

    }

    public void PopupCaja()
    {
        popupCaja.SetActive(true);
    }

    public void closePopUpCaja()
    {
        popupCaja.SetActive(false);
        noMonedas.SetActive(false);
    }

    public void BuyCaja()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 40 && UnlockedItemsNumber >= 3)
        {

            monedasactuales = monedasactuales - 40;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("CajaUnlocked", 1);

            Vendido1.SetActive(true);

            order++;

            powerSe = "CAJA";

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.powerSe =" + powerSe);
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);


            AnalyticsService.Instance.CustomData("BuyPower", new Dictionary<string, object>
            {
            { "powerSe", powerSe },
            { "lastLevel", lastlevel },
             { "order", order }
            });

            popupCaja.SetActive(false);
            noMonedas.SetActive(false);
        }

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") < 40)
        {
            StartCoroutine(timercartelito());
        }
    }

    public void PopupPicante()
    {
        popupPicante.SetActive(true);
    }

    public void closePopUpPicante()
    {
        popupPicante.SetActive(false);
        noMonedas.SetActive(false);
    }
    public void BuyFrenzy()
    {


        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 60 && UnlockedItemsNumber >= 4)
        {

            monedasactuales = monedasactuales - 60;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
            PlayerPrefs.SetInt("FrenzyUnlocked", 1);

            Vendido4.SetActive(true);

            order++;

            powerSe = "PICANTE";

            PlayerPrefs.SetInt("ordenDePotenciador",order);

            Debug.Log("BuyPower.powerSe =" + powerSe);
            Debug.Log("BuyPower.lastLevel =" + lastlevel);
            Debug.Log("BuyPower.order =" + order);


            AnalyticsService.Instance.CustomData("BuyPower", new Dictionary<string, object>
            {
            { "powerSe", powerSe },
            { "lastLevel", lastlevel },
             { "order", order }
            });

            popupPicante.SetActive(false);
            noMonedas.SetActive(false);

        }

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") < 60)
        {
            StartCoroutine(timercartelito());
        }
    }


}
