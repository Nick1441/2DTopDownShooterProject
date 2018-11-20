﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3Burst : MonoBehaviour {

    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
        Instantiate(Prefab, transform.position, rotationInRadians);
        Instantiate(Prefab, transform.position, rotationInRadians);
        Instantiate(Prefab, transform.position, rotationInRadians);
    }
}