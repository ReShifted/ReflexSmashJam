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
            Destroy(gameObject);
            Destroy(particlesinct, expireTime);
            gotHit = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Hammer"))
        {
            manager.AddCoins(10);
            gotHit = true;
        }
        else
        {
            manager.AddCoins(-5);
        }


    }
}
