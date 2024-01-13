using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCollosion : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
