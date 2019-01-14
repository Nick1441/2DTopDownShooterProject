using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBig : MonoBehaviour {

    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public int SpawnAllowed = 0;
    private int EnemyBigAmount = 0;

    public void Update()
    {
        EnemyBigAmount = GameObject.FindGameObjectsWithTag("EnemyBig").Length;
    }

    public void EnemyLimit()
    {
        if (EnemyBigAmount < SpawnAllowed)
        {
            Spawn();
        }
        else
        {

        }
    }

    public void Spawn()
    {
            Vector3 rotationInDegrees = transform.eulerAngles;
            rotationInDegrees.z += adjustmentAngle;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(Prefab, transform.position, rotationInRadians);
    }
}
