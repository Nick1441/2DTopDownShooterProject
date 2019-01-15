using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public delegate void UpdateHealth(int newHealth);
    public static event UpdateHealth OnUpdateHealth;
    //Will need to be changed in invicability script also...
    public float InvTime = 5;

    //this will be used when creating player Animations for firing
    private Animator weaponAnim;

    private void Start()
    {
        weaponAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GetComponent<Animator>().SetBool("isFiring", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("isFiring", false);
        }
    }

    public void SendHealthData(int health)
    {
        if (OnUpdateHealth != null)
        {
            OnUpdateHealth(health);
        }
    }

    public void InvPlayerEnable()
    {
        GetComponent<Animator>().SetBool("isInv", true);
        Invoke("InvPlayerDis", 5f);
    }

    public void InvPlayerDis()
    {
        GetComponent<Animator>().SetBool("isInv", false);
    }

    public void HealedPlayerEnable()
    {
        GetComponent<Animator>().SetBool("isHeal", true);
        Invoke("HealedPlayerDis", 0.1f);
    }

    public void HealedPlayerDis()
    {
        GetComponent<Animator>().SetBool("isHeal", false);
    }

    public void DamagePlayerEnable()
    {
        GetComponent<Animator>().SetBool("isDama", true);
        Invoke("DamagePlayerDis", 0.1f);
    }

    public void DamagePlayerDis()
    {
        GetComponent<Animator>().SetBool("isDama", false);
    }
}

