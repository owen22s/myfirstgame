using UnityEngine;

public class HeartSpawner : MonoBehaviour
{
    public float spawnTime = 2f; // The time between each spawn in seconds
    public GameObject heartPrefab;

    private float timer;

    void Start()
    {
        timer = spawnTime; // Set the timer to the spawn time, so that the first heart will spawn after the specified time
    }

    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnHeart();
            timer = spawnTime;
        }
    }

    void SpawnHeart()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 5f), 5.79f);
        Instantiate(heartPrefab, spawnPosition, Quaternion.Euler(-37.90f, -83.042f, -12f));
    }


}

