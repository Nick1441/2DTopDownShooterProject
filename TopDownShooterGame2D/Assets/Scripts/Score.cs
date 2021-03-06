﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {

    //setting the variables, overall scores.
    public delegate void SendScore(int TheScore);
    public static event SendScore OnSendScore;

    public int TheScore = 10;

    //Used to Determine how much an enemies Score is.
    private void OnDestroy()
    {
        if(OnSendScore != null)
        {
            OnSendScore(TheScore);
        }
    }
}
