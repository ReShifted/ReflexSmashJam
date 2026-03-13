using UnityEngine;

public class being_thrown : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float throwForce = 10f;
    [SerializeField] private float upForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * upForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        Vector3 position = new Vector3(-24.02f, 9.87f, 0f);
        Vector3 direction = position - transform.position;
        direction.y = 0;

        rb.linearVelocity = new Vector3(
            direction.normalized.x * throwForce,
            rb.linearVelocity.y,
            direction.normalized.z * throwForce
        );
    }
}