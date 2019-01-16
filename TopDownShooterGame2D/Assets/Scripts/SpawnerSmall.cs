using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSmall : MonoBehaviour {

    //Selecting which prefab to spawn.
    public GameObject Prefab;
    public float adjustmentAngle = 0;

    public int SpawnAllowed = 0;
    private int EnemySmallAmlount = 0;

    //Finds how many enimies with certain Tag.
    public void Update()
    {
        EnemySmallAmlount = GameObject.FindGameObjectsWithTag("EnemySmall").Length;
    }

    //if enemy amount is under the limit, it will spawn another one when called. If there are enemies above the limit, it will nto spawn.
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

    //Spawns the enemy on the placed Spawner In game.
    public void Spawn()
    {
            Vector3 rotationInDegrees = transform.eulerAngles;
            rotationInDegrees.z += adjustmentAngle;

            Quaternion rotationInRadians = Quaternion.Euler(rotationInDegrees);
            Instantiate(Prefab, transform.position, rotationInRadians);
    }
}
