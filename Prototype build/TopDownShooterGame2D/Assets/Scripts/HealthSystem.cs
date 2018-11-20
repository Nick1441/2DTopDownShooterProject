using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
[System.Serializable]
public class OnHealEvent : UnityEvent<int> { }


public class HealthSystem : MonoBehaviour {

    public int health = 100;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;
    public OnHealEvent HealthPack;

    public void TakeDamage (int damage)
    {
        health -= damage;

        onDamaged.Invoke(health);

        if (health < 1)
        {
           onDie.Invoke();
        }
        else if (health > 100)
        {
            health = 100;
        }
    }
}
