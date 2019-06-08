using System.Collections;
using System.Collections.Generic;
using SeneController;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Vector2 SPEED = new Vector2(0.05f, 0.05f);

    private const float MaxY = 4.2f;
    private const float MaxX = 6.4f;

    SceneController sc;

    private void Start()
    {
        sc = new SceneController();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        sc.ChangeScene("GameOver");
    }

    private void Move()
    {
        Vector2 Position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey(KeyCode.A))
        {
            if (Position.x > -1 * MaxX)
            {
                Position.x -= SPEED.x;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Position.x < MaxX)
            {
                Position.x += SPEED.x;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (Position.y < MaxY)
            {
                Position.y += SPEED.y;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Position.y > -1 * MaxY)
            {
                Position.y -= SPEED.y;
            }
        }

        transform.position = Position;
    }
}