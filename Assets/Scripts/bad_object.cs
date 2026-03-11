using UnityEngine;

public class bad_object : MonoBehaviour
{
    [SerializeField] private float expireTime = 2.0f;
    [SerializeField] private GameObject particals;
    [SerializeField] private bool gotHit = false;

    private void Update()
    {
        explode();
    }
    private void explode()
    {
        if (gotHit)
        {
            GameObject particlesinct = Instantiate(particals, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(particlesinct, expireTime);
            gotHit = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        gotHit = true;
    }
}
