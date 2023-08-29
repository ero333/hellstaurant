using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntajeFinal : MonoBehaviour
{

    public Text texto;

    public Puntaje puntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        texto.text = puntaje.puntos.ToString();
    }
}
