using UnityEngine;

public class good_object : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    [SerializeField] private bool gotHit = false;

    private void Start()
    {
        manager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pillow"))
        {
            manager.AddCoins(10);
            gotHit = true;
            Destroy(gameObject);
        }
        else if (other.CompareTag("Hammer") || other.CompareTag("blocker"))
        {
            manager.AddCoins(-5);
            Destroy(gameObject);
        }

    }
}
