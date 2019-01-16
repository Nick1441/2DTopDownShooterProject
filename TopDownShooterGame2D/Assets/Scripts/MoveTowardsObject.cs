using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour {

    public Transform target;
    public float speed = 5.0f;

    //Find the target (PLayer) and will towards them.
    private void FixedUpdate()
    {
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f);
        }
    }

    //Setting the target to go to.
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
