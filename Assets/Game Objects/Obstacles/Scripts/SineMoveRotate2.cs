﻿using UnityEngine;
using System.Collections;

public class SineMoveRotate2 : MonoBehaviour {

	public float RotateValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler(0 ,Mathf.Sin(Time.realtimeSinceStartup) * RotateValue, 0); 
	}
}
