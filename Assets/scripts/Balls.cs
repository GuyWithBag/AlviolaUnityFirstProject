using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour {

	public Rigidbody[] obj; 
	public Collider[] obj2; 

	// Use this for initialization
	void Start () {
		obj = GetComponentsInChildren<Rigidbody> ();
		obj2 = GetComponentsInChildren<Collider> ();

	}
	
	// Update is called once per frame
	void Update () {
		int balls_moving = 0;

		foreach (Rigidbody t in obj) {
			if (t != null) {
				
			}
		}
	}
}
