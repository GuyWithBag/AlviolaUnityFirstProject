using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<ConstantForce> ().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Fire1")) {
			GetComponent<ConstantForce> ().enabled = true;
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("0")) {
			Destroy (collision.gameObject);
		}
	}
}
