﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	[SerializeField] private Text scoreLabel;
	[SerializeField] private SettingsPopup settingsPopup;
	// Use this for initialization

	private int _score;
	void Start () {
		_score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreLabel.text = Time.realtimeSinceStartup.ToString ();	
	}

	void Awake() {
		Messenger.AddListener (GameEvent.ENEMY_HIT, OnEnemyHit);

	}

	void OnDestroy(){
		Messenger.RemoveListener (GameEvent.ENEMY_HIT, OnEnemyHit);
	}

	public void OnOpenSettings(){
		Debug.Log ("open settings");
		settingsPopup.Open ();
	}
}
