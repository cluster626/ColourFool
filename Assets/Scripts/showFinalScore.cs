﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showFinalScore : MonoBehaviour {
    private int finalScore;
    private Text scoreText;
	// Use this for initialization
	void Start () {
        gameObject.transform.position = gameObject.transform.parent.gameObject.GetComponentInChildren<restartScript>().gameObject.transform.position + new Vector3(0f, 200f, 0);      
        scoreText = gameObject.GetComponent<Text>();
        scoreText.text = scoreHandler.scoreDisplay.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	    finalScore = scoreHandler.scoreDisplay;
	}
}
