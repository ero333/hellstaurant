using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider Slider;

    public void BossSetHealth(float Health, float MaxHealth)
    {
        Slider.gameObject.SetActive(Health <= MaxHealth);
        Slider.value = Health;
        Slider.maxValue = MaxHealth;
    }

    public void reducelife(float Health)
    {
        Slider.value = Health;
    }

}
