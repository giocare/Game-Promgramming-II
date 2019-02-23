using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collision other)
    {
        
    }

    void OnTriggerStay(Collision other)
    {
        rb.AddForce(Vector3.up * 25);
        rb.AddTorque(Vector3.right * 20);
    }

    void OnCollisionExit(Collision other)
    {
        
    }

}
