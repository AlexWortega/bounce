using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_controller : MonoBehaviour
{

    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.forward * 10,ForceMode.Impulse);
        }
        
    }
}
    
