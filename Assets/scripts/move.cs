﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {


	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 moveVector = new Vector3(0,0,Input.acceleration.x);
	transform.Translate(moveVector);
	}
}
