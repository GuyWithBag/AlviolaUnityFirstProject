using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// thjis is supposedly stick.cs

public class StickForce : MonoBehaviour {

	public Text scoreText1; 
	public Text scoreText2;
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
		if (collision.gameObject.CompareTag("2")) {
			if (GameFlow.playerturn == 1) {
				scoreText1.text = "player 1 score: you lost";
				scoreText2.text = "player 2 score: " + GameFlow.score2;
			}
			if (GameFlow.playerturn == 2) {
				scoreText1.text = "player 2 score: you lost";
				scoreText2.text = "player 1 score: " + GameFlow.score1;
			}
		}
		if (collision.gameObject.CompareTag ("0")) {
			Destroy (collision.gameObject);
		}
	}
}
