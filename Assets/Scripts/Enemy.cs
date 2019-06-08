using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float SPEED = 0.05f;

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = transform.position;
        Position.y -= SPEED;
        transform.position = Position;
        if (Position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}