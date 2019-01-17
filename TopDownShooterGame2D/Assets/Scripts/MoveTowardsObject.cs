using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour {

    public Transform target;
    public float speed = 5.0f;

    //Find the target (Player) and will towards them.
    //Goes in direct line. does not point to them. 
    private void FixedUpdate()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }

    //Setting the target to go to.
    //Setting a new target when it is changed.
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
