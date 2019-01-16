using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour {

    //Setting Variables for users to set, e.g. target and smoothness of camera.
    public Transform PlayerTarget;
    public float Smoothness = 5.00f;
    private Vector3 TargetPosition;

    //Setting the camera to continously follow the users position. Times the smoothness changes how quick it will follow them.
	void FixedUpdate ()
    {
        TargetPosition = new Vector3(PlayerTarget.transform.position.x, PlayerTarget.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, TargetPosition, (Smoothness * 0.001f));
	}
}
