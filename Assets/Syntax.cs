﻿using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour {

	public bool boolean1 = false; 
	private bool boolean2 = true; 

	public int interger = 1; 
	public float floatingPoint = 1.1f; 

	// Use this for initialization
	void Start () {
	    if ( boolean1 == true) {
		     Debug.Log ( "Awesome" );
		}

		interger = 10; 
		floatingPoint = 5.4f; 
	}
	
	// Update is called once per frame
	void Update () {
		interger += 1;
	}
}
