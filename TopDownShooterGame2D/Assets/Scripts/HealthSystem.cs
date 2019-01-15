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

    //Big Enemy Dammage Animation On Damaged
    public void OnDamagedAni()
    {
        GetComponent<Animator>().SetBool("isEnDam", true);
        Invoke("OnDamagedAniRes", 0.1f);
    }
    public void OnDamagedAniRes()
    {
        GetComponent<Animator>().SetBool("isEnDam", false);
    }

    //Normal Enemy Animation On Damaged
    public void OnDamagedAniNormal()
    {
        GetComponent<Animator>().SetBool("isEnDamNormal", true);
        Invoke("OnDamagedAniResNormal", 0.1f);
    }
    public void OnDamagedAniResNormal()
    {
        GetComponent<Animator>().SetBool("isEnDamNormal", false);
    }

    //Small Enemy Animation on Damaged
    public void OnDamagedAniSmall()
    {
        GetComponent<Animator>().SetBool("isEnDamSmall", true);
        Invoke("OnDamagedAniResSmall", 0.1f);
    }
    public void OnDamagedAniResSmall()
    {
        GetComponent<Animator>().SetBool("isEnDamSmall", false);
    }


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
