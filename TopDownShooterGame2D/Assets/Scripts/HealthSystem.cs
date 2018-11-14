using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }

public class HealthSystem : MonoBehaviour {

    public int health = 100;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void TakeDamage (int damage)
    {
        health -= damage;

        onDamaged.Invoke(health);

        if (health < 1)
        {
            //Kills The game object Instantly
            Destroy(gameObject);

            //this will be used when i want to create animation for the enemynwhen it is dead.
            //onDie.Invoke();
        }
    }
}
