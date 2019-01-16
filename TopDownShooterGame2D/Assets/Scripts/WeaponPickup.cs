using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    public GameObject weaponPrefab;

    //On Colision, adds Picked up weapon to Component, "Weapon Manager".
    private void OnTriggerEnter2D(Collider2D other)
    {
        WeaponManager weaponManager = other.gameObject.GetComponentInChildren<WeaponManager>();

        if (weaponManager != null)
        {
            weaponManager.AddWeapon(weaponPrefab);
            Destroy(gameObject);
        }
    }
}
