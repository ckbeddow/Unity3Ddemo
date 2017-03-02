﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPopup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Open() {
		gameObject.SetActive (true);

	}

	public void Close() {
		gameObject.SetActive (false);
	}

	public void OnSubmitText( string something){
		Debug.Log (something);
	}

	public void OnSpeedValue( float speed){
		Debug.Log (speed + " speed value");
	}
}
