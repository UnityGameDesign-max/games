﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotate : MonoBehaviour
{
    public float Rotatespeed = 2.5f;
    void Update()
    {
        transform.Rotate(0, 0, Rotatespeed*Time.deltaTime);
        
    }
}
