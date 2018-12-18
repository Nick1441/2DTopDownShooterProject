using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibility : MonoBehaviour {

    public float InvinvabilityTime = 5;

	void Start () {
        transform.GetComponent<Collider2D>().enabled = false;
        Invoke("TimeOut", InvinvabilityTime);
    }

    void TimeOut()
    {
        transform.GetComponent<Collider2D>().enabled = true;
        Destroy(this);
    }
}
