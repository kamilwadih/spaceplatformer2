using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBossHealthUI : MonoBehaviour
{
    public GameObject uiElement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            uiElement.SetActive(true);
        }
    }
}