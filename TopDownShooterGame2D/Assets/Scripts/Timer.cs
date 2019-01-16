using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour {

    //Sets how long Timer is and if it will reapeat. Creates Repeat Unity Event.
    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;
    public float StartTime = 0;

    //Starts timer on Scene Loading.
	private void Start ()
    {
        Invoke("SetRepeatingWait", StartTime);
	}

    //Set the time inbetween each Wait Gap.
    public void SetRepeatingWait()
    {
            if (repeat)
            {
                InvokeRepeating("OnTimerComplete", 0, time);
            }
            else
            {
                Invoke("OnTimerComplete", time);
            }
    }
	
    //When the timer is complete it will restart using the user iputed time.
    private void OnTimerComplete()
    {
        onTimerComplete.Invoke();
    }
}
