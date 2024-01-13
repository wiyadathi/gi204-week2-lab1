using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float torque;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddTorque(0, torque, 0 );
    }

}
