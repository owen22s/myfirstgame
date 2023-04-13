using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public bool onFloor = false;
    public float jumpAmount = 300f;
    public BoxCollider coll;

    void Start()
    {
        //coll = gameObject.GetComponent<BoxCollider>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
           
            onFloor = true;
        }
    }

    void Update()
    {
       // OnCollisionEnter collision = new OnCollisionEnter();

        

        if (Input.GetKeyDown(KeyCode.Space) && onFloor == true)
        {
            Debug.Log("im stupid");

            onFloor = false;
            rb.AddForce(0, jumpAmount, 0);
        }
    }
  

    
}

//