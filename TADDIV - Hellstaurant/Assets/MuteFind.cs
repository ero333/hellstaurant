using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteFind : MonoBehaviour
{

    public Mutear mutescript;


    // Start is called before the first frame update
    void Start()
    {
        mutescript = GameObject.FindGameObjectWithTag ("musicAlterner").GetComponent<Mutear>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mutearSonido()
    {
        mutescript.Mutearr();
    }
}
