using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SCRIPT NOT USED ANYMORE.
public class Spawner3Burst : MonoBehaviour {

    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public void Spawn()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;

        //Used for spawning 3 enemies at a time.
        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
        Instantiate(Prefab, transform.position, rotationInRadians);
        Instantiate(Prefab, transform.position, rotationInRadians);
        Instantiate(Prefab, transform.position, rotationInRadians);
    }
}
