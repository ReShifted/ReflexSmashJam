using UnityEngine;

public class being_thrown : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform target;
    [SerializeField] private float throwForce = 10f;
    [SerializeField] private float upForce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * upForce, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        if (target == null) return;

        Vector3 direction = target.position - transform.position;
        direction.y = 0;

        rb.linearVelocity = new Vector3(
            direction.normalized.x * throwForce,
            rb.linearVelocity.y,
            direction.normalized.z * throwForce
        );
    }
}