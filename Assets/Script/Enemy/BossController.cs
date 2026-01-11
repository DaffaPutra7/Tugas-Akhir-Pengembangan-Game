using UnityEngine;
using TMPro;

public class BossController : MonoBehaviour
{
    [Header("Status Boss")]
    public int maxHealth = 10;
    private int currentHealth;

    [Header("UI HP Boss")]
    public TextMeshProUGUI hpText;

    [Header("Gerakan")]
    public float moveSpeed = 2f;
    public float xLimit = 2f;
    private bool movingRight = true;

    [Header("Serangan")]
    public GameObject bossBulletPrefab;
    public Transform[] firePoints;
    public float fireRate = 1.5f;
    private float nextFire = 0f;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHPText();
    }

    void Update()
    {
        MoveBoss();

        if (Time.time > nextFire)
        {
            Shoot();
            nextFire = Time.time + fireRate;
        }
    }

    void MoveBoss()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (transform.position.x >= xLimit) movingRight = false;
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (transform.position.x <= -xLimit) movingRight = true;
        }
    }

    void Shoot()
    {
        if (bossBulletPrefab != null && firePoints.Length > 0)
        {
            foreach (Transform point in firePoints)
            {
                Instantiate(bossBulletPrefab, point.position, bossBulletPrefab.transform.rotation);
            }
        }
        else if (bossBulletPrefab != null)
        {
            Instantiate(bossBulletPrefab, transform.position, bossBulletPrefab.transform.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Peluru"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        UpdateHPText();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateHPText()
    {
        if (hpText != null)
        {
            hpText.text = "HP Boss : " + currentHealth.ToString();
        }
    }

    void Die()
    {
        GameOverManager gm = FindFirstObjectByType<GameOverManager>();
        if (gm != null)
        {
            gm.TriggerWin();
        }

        Destroy(gameObject);
    }
}