using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtTrigger : MonoBehaviour {

    public int damage;
    public float resetTime = 0.50f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);

    }

    private void ResetTrigger()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<CircleCollider2D>().enabled = true;
    }

}
