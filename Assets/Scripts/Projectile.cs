using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float lifeTime = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.linearVelocity = transform.forward * speed;
        Destroy(gameObject, lifeTime);
    }

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;

        if (rb != null)
        {
            rb.linearVelocity = transform.forward * speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // If the bullet hits the gun, ignore the collision
        if (collision.gameObject.CompareTag("Gun"))
        {
            return;
        }

        // Destroy bullet for any other object
        Destroy(gameObject);
    }
}