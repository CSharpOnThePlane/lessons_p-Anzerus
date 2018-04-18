using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuda : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public Transform monster;
	void Update () {
		float dist = Vector3.Distance(monster.position, transform.position);
		print (dist);
	}
}
