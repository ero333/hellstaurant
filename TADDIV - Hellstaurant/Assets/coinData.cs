using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinData : MonoBehaviour
{

    public Text currentCoinCount;

    public coinData Instance;

    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this; 
    }

    void Start()
    {
        currentCoinCount.text = PlayerPrefs.GetInt("MonedasRecolectadas:").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
