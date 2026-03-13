using UnityEngine;

public class bad_object : MonoBehaviour
{
    [SerializeField] private float expireTime = 2.0f;
    [SerializeField] private GameObject particals;
    [SerializeField] private bool gotHit = false;
    [SerializeField] private GameManager manager;

    private void Start()
    {
        manager = FindFirstObjectByType<GameManager>();
    }
    private void Update()
    {
        explode();
    }
    private void explode()
    {
        if (gotHit)
        {
            GameObject particlesinct = Instantiate(particals, transform.position, Quaternion.identity);
            Destroy(particlesinct, expireTime);
            gotHit = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hammer"))
        {
            manager.AddCoins(10);
            gotHit = true;
            Destroy(gameObject);
        }
        else if(other.CompareTag("Pillow") || other.CompareTag("blocker"))
        {
            manager.AddCoins(-5);
            Destroy(gameObject);
        }


    }
}
