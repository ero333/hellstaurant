using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class MenuPausa : MonoBehaviour
{
   [SerializeField] private GameObject botonPausa;
   [SerializeField] private GameObject menuPausa;

	public Image pausa;
	public Sprite play;
	public Sprite pausasprite;
	public GameObject popupPanel;
    public GameObject popupPausa;
	public GameObject Resume;

	 public void OpenPopup()
    {
        popupPanel.SetActive(true);
        EventSystem.current.SetSelectedGameObject(popupPausa.GetComponentInChildren<Button>().gameObject);
    }

    public void ClosePopup()
    {
        popupPanel.SetActive(false);
        EventSystem.current.SetSelectedGameObject(Resume.GetComponentInChildren<Button>().gameObject);
    }
  
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
		if (Input.GetKeyDown("joystick button 7") || Input.GetKeyDown("escape")) {
            if (pausa.sprite == pausasprite) {
                pausa.sprite = play;
                menuPausa.SetActive(false);
				Time.timeScale = 1f;
            }
            else {
                pausa.sprite = pausasprite;
                menuPausa.SetActive(true);
				Time.timeScale = 0f;
            }
        }

	}



}
