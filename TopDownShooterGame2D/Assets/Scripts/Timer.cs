using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour {


    public float time = 1;
    public bool repeat = false;
    public UnityEvent onTimerComplete;
    public float StartTime = 0;

	private void Start ()
    {
        Invoke("SetRepeatingWait", StartTime);
	}

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
	
    private void OnTimerComplete()
    {
        onTimerComplete.Invoke();
    }
}
