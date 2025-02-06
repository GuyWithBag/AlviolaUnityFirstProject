using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is supposedly stick_rotate.cs

public class StickMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	Vector3 temp;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			transform.Rotate(0, 0, -1);
		} 
		if (Input.GetKey("s")) {
			transform.Rotate(0, 0, 1);
		} 
		if (Input.GetKey("a")) {
			transform.Rotate(-1, 0, 0);
		} 
		if (Input.GetKey("d")) {
			transform.Rotate(1, 0, 0);
		}

		if (Input.GetKey("right")) {
			temp = transform.position;
			temp.x += 0.1f;
			transform.position = temp;
		}
		if (Input.GetKey("left")) {
			temp = transform.position;
			temp.x -= 0.1f;
			transform.position = temp;
		}
		if (Input.GetKey("up")) {
			temp = transform.position;
			temp.y += 0.1f;
			transform.position = temp;
		}
		if (Input.GetKey("down")) {
			temp = transform.position;
			temp.y -= 0.1f;
			transform.position = temp;
		}
	}
}
