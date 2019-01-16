using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickUpSelect
{
    Health,
    invincibility
}

public class PickUps : MonoBehaviour {

    public PickUpSelect PickupType;
    public int HealAmount = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Selection for Pickup Types.
        switch (PickupType)
        {
            //Sending Health To The Player, Healing Them...
            case PickUpSelect.Health:
                //Sends damage to Health System. Send Endable animation on Healing.
                other.transform.SendMessage("TakeDamage", -HealAmount, SendMessageOptions.DontRequireReceiver);
                other.transform.SendMessage("HealedPlayerEnable", SendMessageOptions.DontRequireReceiver);
                break;

            case PickUpSelect.invincibility:
                //Sends message to player to disable Colliders, loads invincability Script.
                other.gameObject.AddComponent<invincibility>();
                other.transform.SendMessage("InvPlayerEnable", SendMessageOptions.DontRequireReceiver);
                break;

            default:
                break;
        }
        Destroy(gameObject);
    }
}
