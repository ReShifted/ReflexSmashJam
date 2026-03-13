using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectA;
    public GameObject objectB;
    public GameObject objectC;

    public float spawnInterval = 2f;

    private BoxCollider spawnArea;

    void Start()
    {
        spawnArea = GetComponent<BoxCollider>();
        InvokeRepeating(nameof(SpawnRandomObject), 0f, spawnInterval);
    }

    void SpawnRandomObject()
    {
        GameObject objectToSpawn;

        if (Random.value < 0.5f)
        {
            objectToSpawn = objectA;
        }
        else if(Random.value > 0.5f &&  Random.value < 1.0f)
        {
            objectToSpawn = objectB;
        }
        else
        {
            objectToSpawn = objectC;    
        }

        Vector3 randomPosition = new Vector3(
            Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x),
            Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y),
            Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z)
        );

        Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
    }
}
