using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolScript : MonoBehaviour
{
    public static BulletPoolScript instance;

    public GameObject pooledBullet;

    public bool notEnoughBullets = true;

    public List<GameObject> bullets;


    public void Awake()
    {
        instance = this; 
    }


    void Start()
    {
        bullets = new List<GameObject>();
    }

    public GameObject getBullet()
    {
        if (bullets.Count == 0)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (!bullets[i].activeInHierarchy)
                {
                    return bullets[i];
                }
            }
        }

        if(notEnoughBullets)
        {
            GameObject bul = Instantiate(pooledBullet);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }
        return null;
    }
    
    void Update()
    {
        
    }
}
