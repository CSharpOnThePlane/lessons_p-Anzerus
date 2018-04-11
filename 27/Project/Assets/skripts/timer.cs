using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float sec = 0;
	void Update () {
		sec=sec + Time.deltaTime;
		print((int)sec);
	}
}
