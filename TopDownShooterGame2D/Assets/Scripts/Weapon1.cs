using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform[] bulletSpawn;
    public float FireRate = 1.0f;

    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }
    
    //Fires the weapon when the Mouse is clicked, (Known by a Bool)
    private void Fire()
    {
        isFiring = true;

        for (int i = 0; i < bulletSpawn.Length; i++)
        {
            Instantiate(bulletPrefab, bulletSpawn[i].position, bulletSpawn[i].rotation);
        }
        //Plays Sound if Object has Component.
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", FireRate);
    }
	
    //Checks for updates pressing the fire Button.
	private void FixedUpdate () {
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
	}
}
