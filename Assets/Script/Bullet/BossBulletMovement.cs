using UnityEngine;

public class BossBulletMovement : MonoBehaviour
{
    public float speed = 5f; 

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        Destroy(gameObject, 4f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameOverManager gm = FindFirstObjectByType<GameOverManager>();
            if (gm != null)
            {
                gm.TriggerGameOver();
            }

            Destroy(gameObject);
        }
    }
}