using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptWave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		print("Hello world!");
	
	}
	
	// Update is called once per frame
	float wave=0;
	float sec=0;
	void Update () {
		
		float second = Time.deltaTime;
		sec =sec + second;
		if (sec > 5)
		{
			print ("новая волна");
			wave = wave+1;
			print (wave);

			sec=0;
		}
			
	}
}
