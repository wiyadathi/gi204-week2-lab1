using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float force;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(force, 0, 0 );
        }

    }

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(force, force, 0);
    }
}
