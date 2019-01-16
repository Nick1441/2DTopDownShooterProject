using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SCRIPT NOT USED ANYMORE. UPDATED MULTIPICKUP USED INSTEAD.
public class HealthPack : MonoBehaviour {

    //Sets how much health you want to give back.
    public int HealthPackAmount = -25;

    //Sends health pickup to player.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.SendMessage("TakeDamage", HealthPackAmount, SendMessageOptions.DontRequireReceiver);
        Die();
    }

    //Used to destroy Game Object.
    private void Die()
    {
        Destroy(gameObject);
    }

}
