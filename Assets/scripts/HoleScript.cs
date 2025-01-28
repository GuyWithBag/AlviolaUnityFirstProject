using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PrintBallsArray() {
		string contents = "balls Array";
		for (int i = 0; i < GameFlow.balls.Length; i++) {
			contents += GameFlow.balls [i] + " "; 
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("1")) {
			GameFlow.balls [0] = 0;
			print (1); 
		} else if (other.gameObject.CompareTag("2")) {
			GameFlow.balls [1] = 0;
			print (2); 
		} else if (other.gameObject.CompareTag("3")) {
			GameFlow.balls [2] = 0;
			print (3); 
		} else if (other.gameObject.CompareTag("4")) {
			GameFlow.balls [3] = 0;
			print (4); 
		} else if (other.gameObject.CompareTag("5")) {
			GameFlow.balls [4] = 0;
			print (5); 
		} else if (other.gameObject.CompareTag("6")) {
			GameFlow.balls [5] = 0;
			print (6); 
		} else if (other.gameObject.CompareTag("7")) {
			GameFlow.balls [6] = 0;
			print (7); 
		} else if (other.gameObject.CompareTag("8")) {
			GameFlow.balls [7] = 0;
			print (8); 
		}

		// (int i = 0; i < 8; i++) {
		//	if (other.gameObject.CompareTag((i + 1).ToString())) {
		//		GameFlow.balls[i] = 0;
		//		print(i);
		//	}
		//}
		PrintBallsArray();
	}
}
