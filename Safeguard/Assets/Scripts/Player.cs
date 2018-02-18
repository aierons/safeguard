﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public Text bankText; 
	public Button gatherButton;

	private int ore; 
	private int wood;
	private int actionCount;

	// Use this for initialization
	void Start () {
		ore = 0;
		wood = 0;
		bankText.text = "";
		actionCount = 3;

		gatherButton.onClick.AddListener (Gather);
	}
	
	// Update is called once per frame
	void Update () {
		bankText.text = "Action Count: " + actionCount.ToString() + "\nOre: " + ore.ToString() + "\nWood: " + wood.ToString();

	}

	void Gather() {
		if (actionCount >= 2) {
			ore += 1;
			wood += 1;

			actionCount--;
		}
	}
}