using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSpawner : MonoBehaviour
{
    //Setting which prefabs to use, once they have been selected by the user.
    public GameObject prefabToSpawn;
    public float adjustmentAngle = 0;

    //Spawns the explosion onto the enemie before the Die.
    //Works out players rotation In degrees, so will be faceing correct way.
    public void Spawn()
    {
        Vector3 rotationInDegrees = transform.eulerAngles;
        rotationInDegrees.z += adjustmentAngle;

        Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
        Instantiate(prefabToSpawn, transform.position, rotationInRadians);
    }
}