using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSystem : MonoBehaviour
{
    private float _timer = 1f;

    private void Update()
    {
        _timer -= Time.deltaTime;
        
        if (_timer >= 0f) return;
        
        Debug.Log("This is a message");

        _timer = 1f;
    }
}
