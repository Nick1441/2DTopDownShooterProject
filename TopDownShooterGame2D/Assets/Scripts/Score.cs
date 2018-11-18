using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    public delegate void SendScore(int TheScore);
    public static event SendScore OnSendScore;

    public int TheScore = 10;

    private void OnDestroy()
    {
        if(OnSendScore != null)
        {
            OnSendScore(TheScore);
        }
    }
}
