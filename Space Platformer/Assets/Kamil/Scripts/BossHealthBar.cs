using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthBar : MonoBehaviour
{
    public Slider slider;
    public BossHealth bossHealth;

    private void Start()
    {
        bossHealth = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHealth>();
        SetMaxHealth(bossHealth.maxHealth);
        SetHealth(bossHealth.maxHealth);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}