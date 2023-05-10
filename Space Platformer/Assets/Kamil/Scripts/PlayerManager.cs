using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    //declare two variables one max and one current health
    public int currentHealth;
    public int maxHealth;
    public HealthBar3 healthBar;

    PlayerMovement pMove;
    void Awake()
    {
        pMove = GetComponent<PlayerMovement>();
    }

    void Start()
    {
        healthBar.SetMaxHealth(maxHealth);
    }

    public int coinCount;

    public void Update()
    {
        if (currentHealth <= 0)
        {
            PauseGame();
        }
    }
    public bool PickupItem(GameObject obj)
    {
        switch (obj.tag)
        {
            case "Currency":
                coinCount++;
                return true;
            case "Speed+":
                pMove.SpeedPowerUp();
                return true;
            case "LowGravity":
                pMove.LowGravityPowerUp();
                return true;
            default:
                Debug.Log("No tag or reference is set for this GameObject");
                return false;
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}