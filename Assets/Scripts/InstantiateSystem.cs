using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSystem : MonoBehaviour
{
    public Vector3 InstantiatePosition;
    public Vector3 InstantiateRotation;
    public float TimeToInstantiate = 1.5f;

    private GameObject _cube;
    private float _timer;

    private void Start()
    {
        _cube = Resources.Load<GameObject>("Cube");
        _timer = TimeToInstantiate;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer >= 0f) return;

        Instantiate(_cube, InstantiatePosition, Quaternion.Euler(InstantiateRotation));

        _timer = TimeToInstantiate;
    }
}