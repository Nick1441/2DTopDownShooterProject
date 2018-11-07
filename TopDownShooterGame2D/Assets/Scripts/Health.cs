using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int?> { }

public class Health : MonoBehaviour {

    public int ObjectHealth = 10;
    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;

    public void DamageTaken(int damage)
    {
        ObjectHealth -= damage;
        onDamaged.Invoke(ObjectHealth);

        if (ObjectHealth < 1)
        {
            onDie.Invoke();
        }
    }
}
