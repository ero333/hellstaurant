using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinData : MonoBehaviour
{

    public Text currentCoinCount;

    // Start is called before the first frame update
    void Start()
    {
        currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
