using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selectionBoxes;

    public GameObject[] prefabs;

    public Sprite personajeHombre;

    public Sprite personajeMujer;

    public Sprite personajeHalloween;

    public Sprite personajeSpiderman;

    public Sprite personajeDorado;


    public SpriteRenderer spriteRendererEspejo;

    public GameObject imagenEspejo;

    public int monedasactuales;


    public GameObject precioMujer;

    public GameObject precioHalloween;

    public GameObject precioSpiderman;

    public coinData coindata;



    public GameObject buyWomanButton;
    public GameObject selectWomanButton;

    public GameObject buyHalloweenButton;
    public GameObject selectHalloweenButton;

    public GameObject buySpidermanButton;
    public GameObject selectSpidermanButton;

    public GameObject goldenSkin;
    public Button selectGoldButton;

    public Sprite goldSkinLocked;
    public Sprite goldSkinUnlocked;

    public SpriteRenderer spriteRendererGoldenSkin;



    // Start is called before the first frame update
    void Start()
    {
        //foreach (var img in this.selectionBoxes)
        //{
        //    img.gameObject.SetActive(false);
        //}

        //this.Select(0);

        selectGoldButton.interactable = false;

        spriteRendererEspejo = imagenEspejo.GetComponent<SpriteRenderer>();

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");


       if( PlayerPrefs.GetString("skin seleccionada") == "halloweenSkin")
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



        selectGoldButton.interactable = false;
        spriteRendererGoldenSkin.sprite = goldSkinLocked;



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


    public void SelectGold()
    {
        PlayerPrefs.SetString("skin seleccionada", "goldSkin");
        spriteRendererEspejo.sprite = personajeDorado;
    }


    public void BuyWomanSkin()
    {
        
        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 1)
        {


            monedasactuales = monedasactuales - 1;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinMujerComprada", 1);

            selectWomanButton.SetActive(true);
            buyWomanButton.SetActive(false) ;
            precioMujer.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectWomanButton.GetComponentInChildren<Button>().gameObject);
        }


    }

    public void BuyHalloweenSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 1)
        {


            monedasactuales = monedasactuales - 1;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinHalloweenComprada", 1);

            selectHalloweenButton.SetActive(true);
            buyHalloweenButton.SetActive(false);
            precioHalloween.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectHalloweenButton.GetComponentInChildren<Button>().gameObject);
        }


    }

    public void BuySpidermanSkin()
    {

        if (PlayerPrefs.GetInt("MonedasRecolectadas:") >= 1)
        {


            monedasactuales = monedasactuales - 1;


            PlayerPrefs.SetInt("MonedasRecolectadas:", monedasactuales);
            coindata.currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();

            PlayerPrefs.SetInt("skinSpidermanComprada", 1);

            selectSpidermanButton.SetActive(true);
            buySpidermanButton.SetActive(false);
            precioSpiderman.SetActive(false);

            EventSystem.current.SetSelectedGameObject(selectSpidermanButton.GetComponentInChildren<Button>().gameObject);
        }

    }

}
