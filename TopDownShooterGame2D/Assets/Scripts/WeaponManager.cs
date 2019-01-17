using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{

    public Text WeaponSelected;

    //Sets user to weapon 1, does not enable multi weapon carry.
    void Start()
    {
        ChangeWeapon(0);
        WeaponSelected.enabled = false;
    }

    //Changes weapon when weapon is picked Up. Adds to array in next available slot.
    public void ChangeWeapon(int index)
    {
        if (index < transform.childCount)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                if (i == index)
                {
                    transform.GetChild(i).gameObject.SetActive(true);
                }
                else
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
        }
    }

    //Adds weapon to array.

    public void AddWeapon(GameObject prefab)
    {
        GameObject weapon = Instantiate(prefab, transform.position, transform.rotation, transform);

        ChangeWeapon(weapon.transform.GetSiblingIndex());
        WeaponSelected.enabled = true;
        WeaponSelected.text = "Weapon - 1";
    }

    //Checks for key press to select specific weapons.
    //Listens for users keypresses.
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeWeapon(0);
            WeaponSelected.text = "Weapon - 1";
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeWeapon(1);
            WeaponSelected.text = "Weapon - 2";
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeWeapon(2);
            WeaponSelected.text = "Weapon - 3";
        }
    }
}
