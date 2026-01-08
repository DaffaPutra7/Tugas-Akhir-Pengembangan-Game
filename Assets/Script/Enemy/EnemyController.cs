using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Peluru"))
        {
            Destroy(other.gameObject);

            Destroy(gameObject);

            // (tambah Script Skor)
        }
        else if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            // Game Over Logic 
            Debug.Log("GAME OVER!");
        }
    }
}