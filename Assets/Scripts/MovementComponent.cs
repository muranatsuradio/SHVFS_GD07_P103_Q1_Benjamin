using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    public float MoveSpeed = 2f;
    
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (!_rigidbody) return;
        _rigidbody.MovePosition(transform.position + transform.forward * MoveSpeed * Time.fixedDeltaTime); 
    }
}