using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon1 : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float FireRate = 1.0f;

    private bool isFiring = false;

    private void SetFiring()
    {
        isFiring = false;
    }
    
    private void Fire()
    {
        isFiring = true;
        Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }

        Invoke("SetFiring", FireRate);
    }
	
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
