using UnityEngine;

public class being_thrown : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private Transform target;
    [SerializeField] private float trowforce = 10f;
    [SerializeField] private float upforce = 5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if(target == null)
        {
            target = transform;
        }
        Vector3 direction = target.position - transform.position;
        direction.y = 0;

        rb.AddForce(direction.normalized *  trowforce, ForceMode.Impulse);
        rb.AddForce(Vector3.up * upforce, ForceMode.Impulse);
    }

    

}
