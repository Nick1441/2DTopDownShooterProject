using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSmall : MonoBehaviour {

    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public int SpawnAllowed = 0;
    private int EnemySmallAmlount = 0;

    public void Update()
    {
        EnemySmallAmlount = GameObject.FindGameObjectsWithTag("EnemySmall").Length;
    }

    public void EnemyLimit()
    {
        if (EnemySmallAmlount < SpawnAllowed)
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
