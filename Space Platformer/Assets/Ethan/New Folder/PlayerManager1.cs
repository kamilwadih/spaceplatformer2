using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager1 : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;

    PlayerMovement pMove;
    void Awake()
    {
        pMove = GetComponent<PlayerMovement>();
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
            default:
                Debug.Log("No tag or refernce is set for this GameObject");
                return false;
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
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

     

