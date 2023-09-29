using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
   [SerializeField] private GameObject botonPausa;
   [SerializeField] private GameObject menuPausa;

	public Image pausa;
	public Sprite play;
	public Sprite pausasprite;
  
	public void Pausa(){
	   Time.timeScale = 0f;
	   menuPausa.SetActive(true);
	   pausa.sprite = play;
   }   

	public void MenuInicial()
	{
        Time.timeScale = 1f;
		botonPausa.SetActive(false);
		menuPausa.SetActive(false);
		SceneManager.LoadScene("Menu");
    }

   public void Reanudar(){
	   Time.timeScale = 1f;
	   menuPausa.SetActive(false);
	   pausa.sprite = pausasprite;
    }

	public void Tienda()
	{
        Time.timeScale = 1f;
		botonPausa.SetActive(false);
		menuPausa.SetActive(false);
		SceneManager.LoadScene("Tienda");
    }

	private void Update(){
		if (Input.GetKey("joystick button 7")){
		Time.timeScale = 0f;
		menuPausa.SetActive(true);
		pausa.sprite = play;
	}
	else if (Input.GetKey("joystick button 1")){
		menuPausa.SetActive(false);
		Time.timeScale = 1f;
		pausa.sprite = pausasprite;
	}

	}



}
