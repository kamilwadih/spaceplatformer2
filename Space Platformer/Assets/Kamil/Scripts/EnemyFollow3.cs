using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow3 : MonoBehaviour
{
    public Transform player;
    public List<Transform> points;
    public int nextId;
    private int idChangeValue = 1;
    public float speed = 2;
    public float flipDistance = 5f;

    // Update is called once per frame
    void Update()
    {
        if (transform != null && player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            if (distanceToPlayer < flipDistance)
            {
                FlipEnemy(player.position.x > transform.position.x);
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            else
            {
                MoveToNextPoint();
            }
        }
    }

    void MoveToNextPoint()
    {
        Transform goalPoint = points[nextId];
        FlipEnemy(goalPoint.position.x > transform.position.x);

        transform.position = Vector2.MoveTowards(transform.position, goalPoint.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, goalPoint.position) < 1f)
        {
            if (nextId == points.Count - 1)
            {
                idChangeValue = -1;
            }

            if (nextId == 0)
            {
                idChangeValue = 1;
            }
            nextId += idChangeValue;
        }
    }

    void FlipEnemy(bool faceRight)
    {
        if (faceRight)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}