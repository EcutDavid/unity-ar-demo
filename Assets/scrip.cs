﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("rotating");
		transform.Rotate(new Vector3(0,100,0) * Time.deltaTime);
	}
}
