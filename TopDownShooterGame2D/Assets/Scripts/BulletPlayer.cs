using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour {

    //Declairing Variables for speed and damage of bullet.
    public float MovementSpeed = 100.0f;
    public int Damage = 1;

    //Gets Rigid Body Compnent on start.
	private void Start ()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * MovementSpeed);
	}

    //Sending the damage to the target that the bullet collides with.
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", Damage, SendMessageOptions.DontRequireReceiver);
        Die();
    }
	
    //Calling the bullet to die when it goes off the users screen.
    private void OnBecameInvisable()
    {
        Die();
    }

    //Killing the bullet, destroying the Game Object.
    private void Die()
    {
        Destroy(gameObject);
    }
}
