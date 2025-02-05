using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoleScript2 : MonoBehaviour {


	public Text oneText;
	public Image one; 
	public Text twoText;
	public Image two;
	public Text threeText;
	public Image three; 
	public Text fourText;
	public Image four;
	public Text fiveText;
	public Image five;
	public Text sixText;
	public Image six;
	public Text sevenText;
	public Image seven;
	public Text eightText;
	public Image eight;
	// Use this for initialization
	void Start () {
		one.enabled = false;
		oneText.enabled = false;
		two.enabled = false;
		twoText.enabled = false;
		three.enabled = false;
		threeText.enabled = false;
		four.enabled = false;
		fourText.enabled = false;
		five.enabled = false;
		fiveText.enabled = false;
		six.enabled = false;
		sixText.enabled = false;
		seven.enabled = false;
		sevenText.enabled = false;
		eight.enabled = false;
		eightText.enabled = false;
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

	void DestroyBallWithTag(string tag) {
		GameObject obj = GameObject.FindWithTag (tag); 
		if (obj != null) {
			Destroy (obj);
		} else {
			Debug.Log ("No GameObject fund with this tag: " + tag); 
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.CompareTag("1")) {
			GameFlow.balls [0] = 0;
			print (1); 
			one.enabled = true;
			oneText.enabled = true;
			DestroyBallWithTag ("1");
		} else if (other.gameObject.CompareTag("2")) {
			GameFlow.balls [1] = 0;
			print (2); 
			two.enabled = true;
			twoText.enabled = true;
			DestroyBallWithTag ("2");
		} else if (other.gameObject.CompareTag("3")) {
			GameFlow.balls [2] = 0;
			print (3); 
			three.enabled = true;
			threeText.enabled = true;
			DestroyBallWithTag ("3");
		} else if (other.gameObject.CompareTag("4")) {
			GameFlow.balls [3] = 0;
			print (4); 
			four.enabled = true;
			fourText.enabled = true;
			DestroyBallWithTag ("4");
		} else if (other.gameObject.CompareTag("5")) {
			GameFlow.balls [4] = 0;
			print (5); 
			five.enabled = true;
			fiveText.enabled = true;
			DestroyBallWithTag ("5");
		} else if (other.gameObject.CompareTag("6")) {
			GameFlow.balls [5] = 0;
			print (6); 
			six.enabled = true;
			sixText.enabled = true;
			DestroyBallWithTag ("6");
		} else if (other.gameObject.CompareTag("7")) {
			GameFlow.balls [6] = 0;
			print (7); 
			seven.enabled = true;
			sevenText.enabled = true;
			DestroyBallWithTag ("7");
		} else if (other.gameObject.CompareTag("8")) {
			GameFlow.balls [7] = 0;
			print (8); 
			eight.enabled = true;
			eightText.enabled = true;
			DestroyBallWithTag ("8");
		} else if (other.gameObject.CompareTag("9")) {
			GameFlow.balls [8] = 0;
			print (9); 
			eight.enabled = true;
			eightText.enabled = true;
			DestroyBallWithTag ("9");
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
