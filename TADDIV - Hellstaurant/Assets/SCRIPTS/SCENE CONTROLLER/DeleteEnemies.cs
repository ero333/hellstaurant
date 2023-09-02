using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteEnemies : MonoBehaviour
{
    public string tagEnemy = "Enemy";



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject[] taggedEnemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject obj in taggedEnemies)
        {

            DestroyImmediate(obj);


        }
    }
}
