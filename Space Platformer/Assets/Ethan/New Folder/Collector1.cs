using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectable1 collectable = collision.GetComponent<ICollectable1>();
        if(collectable != null)
        {
            collectable.Collect();
        }
    }
}
