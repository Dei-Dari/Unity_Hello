using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TestSphere : MonoBehaviour
{
    private Rigidbody rb;
    private void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.right);
        }
    }

    //private void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}
}
