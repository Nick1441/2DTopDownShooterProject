using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour
{

    public Text WeaponSelected;

    void Start()
    {
        ChangeWeapon(0);
        WeaponSelected.enabled = false;
    }

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

    public void AddWeapon(GameObject prefab)
    {
        GameObject weapon = Instantiate(prefab, transform.position, transform.rotation, transform);

        ChangeWeapon(weapon.transform.GetSiblingIndex());
        WeaponSelected.enabled = true;
        WeaponSelected.text = "Weapon - 1";
    }

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
