using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
   [SerializeField] private GameObject botonPausa;
   [SerializeField] private GameObject menuPausa;

   public void Pausa(){
	   Time.timeScale = 0f;
	   botonPausa.SetActive(false);
	   menuPausa.SetActive(true);

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
	   botonPausa.SetActive(true);
	   menuPausa.SetActive(false);

   }

}
