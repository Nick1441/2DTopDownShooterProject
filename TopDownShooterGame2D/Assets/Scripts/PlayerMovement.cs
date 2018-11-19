using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Setting the players speed to 6, this can be changed as it is a public variable.
    public float speed = 6.0f;

    //Setting the RigidMovement Property as a RigidBody Component, This is what will move the object.
    Rigidbody2D RigidMovement;

	// Use this for initialization
	void Start () {
        //Getting the rigid body component from the object.
        RigidMovement = GetComponent<Rigidbody2D>();
	}
	
	// Function Is Called Each Frame Update.
	void FixedUpdate () {
        //Setting The Angual velocity to 0, as this will prevent the player from spinning while playing.
        RigidMovement.angularVelocity = 0.0f;

        //Creating A New Vector2, To store both the Horizontal And Vertical Movement Inputed.
        Vector2 Movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        //Making The players Velocity Dependent on The players Input, Allowing the Object To Move.
        //This is then Timed by speed, allowing the player to move faster or slower, as Speed is a Variable.
        RigidMovement.velocity = Movement * speed;
	}
}
