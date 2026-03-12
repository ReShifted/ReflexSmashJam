using UnityEngine;

public class good_object : MonoBehaviour
{
    [SerializeField] private GameManager manager;

    private void Start()
    {
        manager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Pillow"))
        {
            manager.AddCoins(10);
            Destroy(gameObject);
        }
        else
        {
            manager.AddCoins(-5);
            Destroy(gameObject);
        }
            
    }
}
