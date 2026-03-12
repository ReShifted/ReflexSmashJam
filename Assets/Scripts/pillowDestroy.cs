using UnityEngine;

public class pillowDestroy : MonoBehaviour
{
    [SerializeField] private Pillow pillow;

    private void Start()
    {
        pillow = FindFirstObjectByType<Pillow>();
    }

    private void Update()
    {
        if(pillow.isBlocking == false)
        {
            Destroy(gameObject);
        }
    }
}
