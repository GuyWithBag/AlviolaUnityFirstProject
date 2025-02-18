using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBall_CollisionEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.CompareTag ("1")) {
			GameFlow.balls [0] = 0;
			print ("ball 1");
		}
		if (collision.gameObject.CompareTag ("2")) {
			GameFlow.balls [1] = 1;
			print ("ball 2");
		}
		if (collision.gameObject.CompareTag ("3")) {
			GameFlow.balls [2] = 2;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("4")) {
			GameFlow.balls [3] = 3;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("5")) {
			GameFlow.balls [4] = 4;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("6")) {
			GameFlow.balls [5] = 5;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("7")) {
			GameFlow.balls [6] = 6;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("8")) {
			GameFlow.balls [7] = 7;
			print ("ball 3");
		}
		if (collision.gameObject.CompareTag ("9")) {
			GameFlow.balls [8] = 8;
			print ("ball 3");
		}
	}
	void PrintBallArray()
	{
		string arrayContents = "Balls array: ";
		for (int i = 0; i < GameFlow.balls.Length; i++) {
			arrayContents += GameFlow.balls[i] + " ";
			Debug.Log(arrayContents);
		}
	}
}
