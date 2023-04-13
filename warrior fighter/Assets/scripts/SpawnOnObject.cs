using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnObject : MonoBehaviour
{
    public GameObject prefabToClone;
    public KeyCode spawnButton = KeyCode.Space;
    public GameObject spawnLocation;
    public float spawnCooldown = 0.5f; // Cooldown in seconds
    private float timeSinceLastSpawn = 0.0f;

    void Update()
    {
        // Check if the spawn button is pressed and the cooldown has expired
        if (Input.GetKeyDown(spawnButton) && Time.time >= timeSinceLastSpawn + spawnCooldown)
        {
            // Clone the prefab and store a reference to the clone
            GameObject clone = Instantiate(prefabToClone, spawnLocation.transform.position, spawnLocation.transform.rotation);

            // Destroy the clone after 0.2 seconds
            Destroy(clone, 0.09f);

            // Reset the time since last spawn
            timeSinceLastSpawn = Time.time;
        }
    }
}
