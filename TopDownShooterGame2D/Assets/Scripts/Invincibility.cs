using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibility : MonoBehaviour {

    //Sets how long invincability will last for.
    public float InvinvabilityTime = 5;

    //Setting the Colliders to off so cannot be damage until reset time.
	void Start () {
        transform.GetComponent<Collider2D>().enabled = false;
        Invoke("TimeOut", InvinvabilityTime);
    }

    //Turns back on Colliders.
    void TimeOut()
    {
        transform.GetComponent<Collider2D>().enabled = true;
        Destroy(this);
    }
}
