using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtTrigger : MonoBehaviour {

    public int damage;
    public float resetTime = 0.50f;

    //Sends hurt message to player. Turns off Colliders for Reset time before they can hurt again.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        collision.transform.SendMessage("DamagePlayerEnable", SendMessageOptions.DontRequireReceiver);

        GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        Invoke("ResetTrigger", resetTime);

    }

    //Turns back on the 2D Colliders.
    private void ResetTrigger()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<CircleCollider2D>().enabled = true;
    }

}
