using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyBallWithTag(string tag) {
		GameObject obj = GameObject.FindWithTag (tag); 
		if (obj != null) {
			
		}
	}
}
