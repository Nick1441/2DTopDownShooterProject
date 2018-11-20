using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtTrigger : MonoBehaviour {

    public int damage;
    public float resetTime = 0.50f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        GetComponent<Collider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);
    }

    private void ResetTrigger()
    {
        GetComponent<Collider2D>().enabled = true;
    }
}
