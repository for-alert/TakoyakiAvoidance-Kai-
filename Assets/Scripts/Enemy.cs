using UnityEngine;

public class Enemy : MonoBehaviour
{
    private const float SPEED = 0.05f;

    private void Update()
    {
        Vector2 position = transform.position;
        position.y -= SPEED;
        transform.position = position;
        if (position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}