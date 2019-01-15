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
        switch (PickupType)
        {
            //Sending Health To The Player, Healing Them...
            case PickUpSelect.Health:
                other.transform.SendMessage("TakeDamage", -HealAmount, SendMessageOptions.DontRequireReceiver);
                other.transform.SendMessage("HealedPlayerEnable", SendMessageOptions.DontRequireReceiver);
                break;

            case PickUpSelect.invincibility:
                other.gameObject.AddComponent<invincibility>();
                other.transform.SendMessage("InvPlayerEnable", SendMessageOptions.DontRequireReceiver);
                break;

            default:
                break;
        }
        Destroy(gameObject);
    }
}
