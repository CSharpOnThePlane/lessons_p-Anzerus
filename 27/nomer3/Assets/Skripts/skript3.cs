using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skript3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	float time = 20;
	void Update () {
		
		time = time - Time.deltaTime;
		if (time>0) {
			print ((int)time);
		}

		if (time<0) {
			print ("время вышло");
		}
	}

}
