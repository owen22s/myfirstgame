using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebullet : MonoBehaviour
{
    public float speed = 500f;
    public Rigidbody rb;
    void Start()
    {
       Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rb.velocity = rb.transform.forward * speed * Time.fixedDeltaTime;
    }
}
