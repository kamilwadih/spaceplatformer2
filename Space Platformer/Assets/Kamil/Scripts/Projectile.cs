using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    private Rigidbody2D rb;
    private float speed = 0.2f;
    private GameObject player;
    private BossHealth bossHealth;

    private Vector3 direction;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        bossHealth = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossHealth>();
    }

    private void Start()
    {
        if (player.transform.rotation.y < 0)
        {
            direction = new Vector3(-speed, 0, 0);
        }
        else
        {
            direction = new Vector3(speed, 0, 0);
        }
    }

    private void Update()
    {
        rb.MovePosition(transform.position + direction);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Boss")
        {
            bossHealth.TakeDamage(10);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
