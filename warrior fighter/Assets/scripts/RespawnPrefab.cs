using UnityEngine;

public class RespawnPrefab : MonoBehaviour
{
    public GameObject prefabToRespawn;
    public float respawnDelay = 3.0f;

    private GameObject spawnedPrefab;

    void Start()
    {
        SpawnPrefab();
    }

    void SpawnPrefab()
    {
        spawnedPrefab = Instantiate(prefabToRespawn, transform.position, transform.rotation);
    }

    void Update()
    {
        if (spawnedPrefab == null)
        {
            Invoke("SpawnPrefab", respawnDelay);
        }
    }
}

