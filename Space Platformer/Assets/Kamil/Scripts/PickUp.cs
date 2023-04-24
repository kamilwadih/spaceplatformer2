using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            PlayerManager manager = col.GetComponent<PlayerManager>();

            if (manager)
            {
                bool pickedUp = manager.PickupItem(gameObject);
                if (pickedUp)
                {
                    Destroy(gameObject);
                }
            }

        }

    }
}