using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;
    public BossHealthBar BossHealth;


    void Start()
    {
        Hitpoints = MaxHitpoints;
        BossHealth.BossSetHealth(Hitpoints, MaxHitpoints);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
