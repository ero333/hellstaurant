using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerHealth : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;

    public float Health, MaxHealth;

    private void Start()
    {
        Health = MaxHealth;
    }

    public void TakeDamage(float amount)
    {
        Health -= amount;
        OnPlayerDamaged?.Invoke();


        if (Health <= 0)
        {
            Health = 0;
            Debug.Log("u r dead");
            OnPlayerDeath?.Invoke();
        }


    }


}
