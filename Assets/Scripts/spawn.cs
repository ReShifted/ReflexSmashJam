using UnityEngine;

    public class RandomSpawner : MonoBehaviour
    {
        public GameObject objectA;
        public GameObject objectB;

        public float spawnInterval = 2f;

        void Start()
        {
            InvokeRepeating(nameof(SpawnRandomObject), 0f, spawnInterval);
        }

        void SpawnRandomObject()
        {
            GameObject objectToSpawn;

            if (Random.value < 0.5f)
            {
                objectToSpawn = objectA;
            }
            else
            {
                objectToSpawn = objectB;
            }

            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }

