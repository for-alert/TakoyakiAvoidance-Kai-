using SeneController;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 speed = new Vector2(0.05f, 0.05f);

    private const float MaxY = 4.2f;
    private const float MaxX = 6.4f;

    SceneController sc;

    private void Start()
    {
        sc = new SceneController();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        sc.ChangeScene("GameOver");
    }

    private void Move()
    {
        Vector2 position = transform.position;
        // 左キーを押し続けていたら
        if (Input.GetKey(KeyCode.A))
        {
            if (position.x > -1 * MaxX)
            {
                position.x -= speed.x;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (position.x < MaxX)
            {
                position.x += speed.x;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (position.y < MaxY)
            {
                position.y += speed.y;
            }
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (position.y > -1 * MaxY)
            {
                position.y -= speed.y;
            }
        }

        transform.position = position;
    }
}