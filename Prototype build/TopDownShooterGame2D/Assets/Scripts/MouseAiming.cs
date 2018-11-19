using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAiming : MonoBehaviour {

    //This is how smooth we want the object to rotate the mouse to.
    //The Higher it is, he faster it will snap to the rotation angle.
    public float Smoothness = 5.00f;

    //This is the rotation angle incase the object starts facing the incorrect way.
    public float AngleAdjustment = 0.00f;

    //This is the camera Component, from the camera class. 
    //This will allow us to use the camera to find the points for the mouse on the screen.
    public Camera MainCamera;

	
    //Every frame, this will be called, allowing the mouses position to calculated and let the object turn towards it.
	void Update () {

        //Finding the mouses point on screen, will find X, Y & Z. Z will be ignored as 2D game.
        Vector3 AimDirection = MainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        //This is finding the diffenrce between the two points. This will mean we can find where the object needs to point to.
        Vector3 Differnce = AimDirection - transform.position;
    
        //This is will reduce the size of the value, back down to a usable, smaller value. A long number isnt required.
        Differnce.Normalize();

        //This is to find the angle our differnce is facing Compared to our object.
        //This is returned in Radions, So Rad2Deg will convert it into Degrees.
        float RotAmount = Mathf.Atan2(Differnce.y, Differnce.x) * Mathf.Rad2Deg;

        //This is what deals with the rotation. It creates a new rotation, where it uses the Z rotation Axis and the adjustment angle.
        //X & Y are set to zero as this is a 2D game, so rotating in the other 2 directions are not required.
        Quaternion NextRotation = Quaternion.Euler(new Vector3(0.00f, 0.00f, RotAmount + AngleAdjustment));

        //This sets the playerss rotation using the Next Rotation. The Time.Delta will decide how fast to rotate.
        //This uses the smoothing to set how smooth it will rotate, lower numbers will be quicker snaps.
        transform.rotation = Quaternion.Lerp(transform.rotation, NextRotation, Time.deltaTime * Smoothness);
	}
}
