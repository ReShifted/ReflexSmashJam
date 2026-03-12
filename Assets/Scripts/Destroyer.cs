using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private Hammer hammer;

    private void Start()
    {
        hammer = FindFirstObjectByType<Hammer>();
    }

    private void Update()
    {
        if(hammer.isHitting == false)
        {
            Destroy(gameObject);
        }
    }
}
