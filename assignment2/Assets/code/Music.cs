﻿using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {
	public AudioClip tech;
	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
