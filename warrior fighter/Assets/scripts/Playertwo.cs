using UnityEngine;

public class Playertwo : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Get horizontal and vertical inputs
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 2f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1f;
        }

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f).normalized;

        // Apply movement
        transform.position += movement * speed * Time.deltaTime;
    }
}