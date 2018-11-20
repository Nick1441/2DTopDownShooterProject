using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {


    public Text ScoreText;

	// Use this for initialization
	void Start () {
        string OverallScore;
        OverallScore = PlayerPrefs.GetString("Player Score");
        ScoreText.text = OverallScore;
    }
}
