using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickup : MonoBehaviour
{
    private KeepScore scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = FindObjectOfType<KeepScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scoreScript.AddScore(5);
            Destroy(gameObject);
        }
    }
}

