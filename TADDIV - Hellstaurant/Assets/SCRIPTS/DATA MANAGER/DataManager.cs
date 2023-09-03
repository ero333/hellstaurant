using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{

    public Puntaje scoreNumber;
    public TextMeshProUGUI currentScoreText;

    public Text scoreRecordTxT;

    // Start is called before the first frame update
    void Start()
    {
        scoreNumber.puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //currentScoreText.text = scoreNumber.puntos.ToString();
    }
}
