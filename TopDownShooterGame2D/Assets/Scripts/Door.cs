using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    public bool Locked;
    public Animator anim;

	// Use this for initialization
	void Start () {
		Locked = true;
        anim = GetComponent<Animator>();
    }
	
    private void DoorOpen(Collider2D other)
    {
        Locked = false;

        if (Locked == true)
        {
            anim.Play("DoorClosed_2");
            anim.Play("DoorClosed_1");
        }
        else
        {
            anim.Play("DoorOoen_1");
            anim.Play("DoorOpen_2");
        }
    }

	// Update is called once per frame
	void Update () {
        

	}
}
