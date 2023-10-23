using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Analytics;
using Unity.Services.Analytics;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selectionBoxes;

    public GameObject[] prefabs;

    public Sprite personajeHombre;

    public Sprite personajeMujer;

    public Sprite personajeHalloween;

    public Sprite personajeSpiderman;

    public Sprite personajeDorado;

    public Sprite personajeMessi;


    public SpriteRenderer spriteRendererEspejo;

    public GameObject imagenEspejo;

    public int monedasactuales;


    public GameObject precioMujer;

    public GameObject precioHalloween;

    public GameObject precioSpiderman;

    public GameObject precioMessi;

    public coinData coindata;



    public GameObject buyWomanButton;
    public GameObject selectWomanButton;

    public GameObject buyHalloweenButton;
    public GameObject selectHalloweenButton;

    public GameObject buySpidermanButton;
    public GameObject selectSpidermanButton;

    public GameObject goldenSkin;
    public Button selectGoldButton;

    public GameObject buyMessiButton;
    public GameObject selectMessiButton;

    public Sprite goldSkinLocked;
    public Sprite goldSkinUnlocked;

    public SpriteRenderer spriteRendererGoldenSkin;

    public int lastlevel;

    public int order = 0;


    public string skinSe;


    // Start is called before the first frame update
    void Start()
    {
        //foreach (var img in this.selectionBoxes)
        //{
        //    img.gameObject.SetActive(false);
        //}

        //this.Select(0);
        order = PlayerPrefs.GetInt("ordenDeSkin");

        //lastlevel = PlayerPrefs.GetInt("UltimoNivelAlcanzado");

        selectGoldButton.interactable = false;

        spriteRendererEspejo = imagenEspejo.GetComponent<SpriteRenderer>();

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");


        if (PlayerPrefs.GetString("skin seleccionada") == "halloweenSkin")
        {
            spriteRendererEspejo.sprite = personajeHalloween;
        }

        if (PlayerPrefs.GetString("skin seleccionada") == "girlSkin")
        {
            spriteRendererEspejo.sprite = personajeMujer;
        }

        if (PlayerPrefs.GetString("skin seleccionada") == "manSkin")
        {
            spriteRendererEspejo.sprite = personajeHombre;
        }

        if (PlayerPrefs.GetString("skin seleccionada") == "spidermanSkin")
        {
            spriteRendererEspejo.sprite = personajeSpiderman;
        }

        if (PlayerPrefs.GetString("skin seleccionada") == "goldSkin")
        {
            spriteRendererEspejo.sprite = personajeDorado;
        }

        if (PlayerPrefs.GetString("skin seleccionada") == "messiSkin")
        {
            spriteRendererEspejo.sprite = personajeMessi;
        }




        selectGoldButton.interactable = false;
        spriteRendererGoldenSkin.sprite = goldSkinLocked;



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






    }


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {

            monedasactuales = monedasactuales + 150;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

        }

        if (PlayerPrefs.GetInt("skinMujerComprada") == 1)
        {
            selectWomanButton.SetActive(true);
            buyWomanButton.SetActive(false);
            precioMujer.SetActive(false);
        }
        else
        {
            selectWomanButton.SetActive(false);
            buyWomanButton.SetActive(true);
            precioMujer.SetActive(true);
        }


        if (PlayerPrefs.GetInt("skinHalloweenComprada") == 1)
        {
            selectHalloweenButton.SetActive(true);
            buyHalloweenButton.SetActive(false);
            precioHalloween.SetActive(false);
        }
        else
        {
            selectHalloweenButton.SetActive(false);
            buyHalloweenButton.SetActive(true);
            precioHalloween.SetActive(true);
        }

        if (PlayerPrefs.GetInt("skinSpidermanComprada") == 1)
        {
            selectSpidermanButton.SetActive(true);
            buySpidermanButton.SetActive(false);
            precioSpiderman.SetActive(false);
        }
        else
        {
            selectSpidermanButton.SetActive(false);
            buySpidermanButton.SetActive(true);
            precioSpiderman.SetActive(true);
        }

        if (PlayerPrefs.GetInt("skinMessiComprada") == 1)
        {
            selectMessiButton.SetActive(true);
            buyMessiButton.SetActive(false);
            precioMessi.SetActive(false);
        }
        else
        {
            selectMessiButton.SetActive(false);
            buyMessiButton.SetActive(true);
            precioMessi.SetActive(true);
        }


        if (PlayerPrefs.GetInt("goldSkinConseguida") == 1)
        {
            selectGoldButton.interactable = true;
            spriteRendererGoldenSkin.sprite = goldSkinUnlocked;
        }
        else
        {
            selectGoldButton.interactable = false;
            spriteRendererGoldenSkin.sprite = goldSkinLocked;
        }

        if (PlayerPrefs.GetInt("UltimoNivelAlcanzado") >= 18)
        {
            PlayerPrefs.SetInt("goldSkinConseguida", 1);

        }

    }


    public void Select(int index)
    {
        foreach (var img in this.selectionBoxes)
        {
            img.gameObject.SetActive(false);
        }

        this.selectionBoxes[index].gameObject.SetActive(true);
        PlayerStorage.playerPrefab = this.prefabs[index];
    }


    public void SelectGirl()
    {
        PlayerPrefs.SetString("skin seleccionada", "girlSkin");

        spriteRendererEspejo.sprite = personajeMujer;
    }

    public void SelectHalloween()
    {
        PlayerPrefs.SetString("skin seleccionada", "halloweenSkin");

        spriteRendererEspejo.sprite = personajeHalloween;
    }

    public void SelectSpiderman()
    {
        PlayerPrefs.SetString("skin seleccionada", "spidermanSkin");

        spriteRendererEspejo.sprite = personajeSpiderman;
    }
    public void SelectMan()
    {
        PlayerPrefs.SetString("skin seleccionada", "manSkin");
        spriteRendererEspejo.sprite = personajeHombre;
    }



    public void SelectMessi()
    {
        PlayerPrefs.SetString("skin seleccionada", "messiSkin");

        spriteRendererEspejo.sprite = personajeMessi;
    }


    public void SelectGold()
    {
        PlayerPrefs.SetString("skin seleccionada", "goldSkin");
        spriteRendererEspejo.sprite = personajeDorado;
    }


    public void BuyWomanSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 150)
        {


            monedasactuales = monedasactuales - 150;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinMujerComprada", 1);

            selectWomanButton.SetActive(true);
            buyWomanButton.SetActive(false);
            precioMujer.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectWomanButton.GetComponentInChildren<Button>().gameObject);

            order++;

            PlayerPrefs.SetInt("ordenDeSkin", order);

            skinSe = "MUJER";

            Debug.Log("BuySkin.skinSe =" + skinSe);
            Debug.Log("BuySkin.lastLevel =" + lastlevel);
            Debug.Log("BuySkin.order =" + order);


            AnalyticsService.Instance.CustomData("BuySkin", new Dictionary<string, object>
            {
            { "order", order },
             { "lastLevel", lastlevel },
              { "skinSe", skinSe },
            });

        }


    }

    public void BuyHalloweenSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 200)
        {


            monedasactuales = monedasactuales - 200;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinHalloweenComprada", 1);

            selectHalloweenButton.SetActive(true);
            buyHalloweenButton.SetActive(false);
            precioHalloween.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectHalloweenButton.GetComponentInChildren<Button>().gameObject);

            order++;

            PlayerPrefs.SetInt("ordenDeSkin", order);

            skinSe = "HALLOWEEN";

            Debug.Log("BuySkin.skinSe =" + skinSe);
            Debug.Log("BuySkin.lastLevel =" + lastlevel);
            Debug.Log("BuySkin.order =" + order);



            AnalyticsService.Instance.CustomData("BuySkin", new Dictionary<string, object>
            {
            { "order", order },
             { "lastLevel", lastlevel },
              { "skinSe", skinSe },
            });

        }


    }

    public void BuySpidermanSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 350)
        {


            monedasactuales = monedasactuales - 350;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinSpidermanComprada", 1);

            selectSpidermanButton.SetActive(true);
            buySpidermanButton.SetActive(false);
            precioSpiderman.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectSpidermanButton.GetComponentInChildren<Button>().gameObject);

            order++;

            PlayerPrefs.SetInt("ordenDeSkin", order);

            skinSe = "SPIDERMAN";

            Debug.Log("BuySkin.skinSe =" + skinSe);
            Debug.Log("BuySkin.lastLevel =" + lastlevel);
            Debug.Log("BuySkin.order =" + order);



            AnalyticsService.Instance.CustomData("BuySkin", new Dictionary<string, object>
            {
            { "order", order },
             { "lastLevel", lastlevel },
              { "skinSe", skinSe },
            });


        }



    }


    public void BuyMessiSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 1000)
        {


            monedasactuales = monedasactuales - 1000;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinMessiComprada", 1);

            selectMessiButton.SetActive(true);
            buyMessiButton.SetActive(false);
            precioMessi.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectMessiButton.GetComponentInChildren<Button>().gameObject);

            order++;

            PlayerPrefs.SetInt("ordenDeSkin", order);

            skinSe = "MESSI";

            Debug.Log("BuySkin.skinSe =" + skinSe);
            Debug.Log("BuySkin.lastLevel =" + lastlevel);
            Debug.Log("BuySkin.order =" + order);



            AnalyticsService.Instance.CustomData("BuySkin", new Dictionary<string, object>
            {
            { "order", order },
             { "lastLevel", lastlevel },
              { "skinSe", skinSe },
            });
        }

    }
}
