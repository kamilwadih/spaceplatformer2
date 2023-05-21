using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBoss : MonoBehaviour
{

    public GameObject bossHealthBar;
    private bool isActivated = false;

    private void Start()
    {
        bossHealthBar.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isActivated == false)
        {
            isActivated = true;
            bossHealthBar.SetActive(true);
        }

    }

}
