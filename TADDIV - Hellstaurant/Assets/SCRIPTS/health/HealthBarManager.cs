using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarManager : MonoBehaviour
{
    public GameObject HeartPrefab;
    public PlayerHealth playerHealth;
    List<HealthHeart> hearts = new List<HealthHeart>();

    private void Start()
    {
        DrawHearts();
    }

    public void DrawHearts()
    {
        ClearHearts();
        //determina cantindad total de corazones basado en la salud max
        float maxHealthRemainder = playerHealth.MaxHealth % 2;
        int heartsToMake = (int)(playerHealth.MaxHealth / 2 + maxHealthRemainder);
        for(int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        for(int i = 0; 1 < hearts.Count; i++)
        {
            int heartStatusRemainder = (int)Mathf.Clamp(playerHealth.Health - (i*2), 0, 2);
            hearts[i].SetHeartImage((HeartStatus)heartStatusRemainder);
        }
    }


    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(HeartPrefab);
        newHeart.transform.SetParent(transform);

        HealthHeart HeartComponent = newHeart.GetComponent<HealthHeart>();
        HeartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(HeartComponent);

    }



    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HealthHeart>();
    }
}
