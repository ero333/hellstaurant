using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selectionBoxes;

    public GameObject[] prefabs;

    public Sprite personajeHombre;

    public Sprite personajeMujer;

    public SpriteRenderer spriteRendererEspejo;

    public GameObject imagenEspejo;

    public int monedasactuales;


    public GameObject precioMujer;


    public coinData coindata;



    public GameObject buyWomanButton;
    public GameObject selectWomanButton;


    // Start is called before the first frame update
    void Start()
    {
        //foreach (var img in this.selectionBoxes)
        //{
        //    img.gameObject.SetActive(false);
        //}

        //this.Select(0);

        spriteRendererEspejo = imagenEspejo.GetComponent<SpriteRenderer>();

        monedasactuales = PlayerPrefs.GetInt("MonedasRecolectadas:");
        
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

    public void SelectMan()
    {
        PlayerPrefs.SetString("skin seleccionada", "manSkin");
        spriteRendererEspejo.sprite = personajeHombre;
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
        }


    }

}
