using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
   

    public float puntos = 0;



    private TextMeshProUGUI textMesh;

    public EnemyBasicDamage enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = puntos.ToString("0");
    }

    public void obtenerPuntaje (int amount)
    {
        puntos += amount;
        
       
    }
}
