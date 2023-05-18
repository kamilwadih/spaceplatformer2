using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage4 : MonoBehaviour
{
    public PlayerManager playerManager;
    public int damage = 0;
    public Animator animator;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            animator.SetTrigger("Attack");
            playerManager.TakeDamage(damage);
        }
    }
}


