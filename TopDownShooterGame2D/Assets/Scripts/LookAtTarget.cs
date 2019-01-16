using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour {
    public Transform target;
    public float Smoothness = 5.0f;
    public float AdjustmentAngle = 0.0f;
	
    //Finds the players Location, Finds current lcoation of enemy and works what direction the player is in.
	public void FixedUpdate ()
    {
		if (target != null)
        {
            Vector3 differnce = target.position - transform.position;
            float rotZ = Mathf.Atan2(differnce.y, differnce.x) * Mathf.Rad2Deg;
            Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + AdjustmentAngle));
            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * Smoothness);
        }
	}

    //Sets new Target of the transform location of User Selected Target.
    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}
