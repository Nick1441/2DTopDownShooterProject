using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour {

    public int HealthPackAmount = -25;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", HealthPackAmount, SendMessageOptions.DontRequireReceiver);
        Die();
    }

    private void Die()
    {
        Destroy(gameObject);
    }

}
