using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour {

    public float MovementSpeed = 100.0f;
    public int Damage = 1;

	private void Start ()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * MovementSpeed);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", Damage, SendMessageOptions.DontRequireReceiver);
        Die();
    }
	
    private void OnBecameInvisable()
    {
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
