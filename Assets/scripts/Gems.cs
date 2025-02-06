using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gems : MonoBehaviour {
	public TextMesh[] numbers; 
	public GameObject[] gemsArray;
	private int[] activeNumbers = new int[10]; 
	private int activeCount = 0;

	// Use this for initialization
	void Start () {
		numbers = GetComponentsInChildren<TextMesh>(true); 
		// ShowNumbers (1); 
	}

	public void ShowNumbers(int value)
	{
		if (!IsNumberActive(value)) {
			activeNumbers [activeCount] = value; 
			activeCount++; 
		}
		foreach (GameObject gem in gemsArray) {
			gem.SetActive (false); 
		}

		for (int i = 5; i < numbers.Length; i++) {
			if (numbers [i] != null) {
				numbers [i].gameObject.SetActive (false); 
			}
		}

		for (int j = 0; j < activeCount; j++) {
			int activeValue = activeNumbers [j]; 
			for (int i = 5; i < numbers.Length; i++) 
			{
				int number; 
				if (numbers [i] != null && int.TryParse (numbers [i].text, out number) && number == activeValue) {
					numbers [i].gameObject.SetActive (true); 
				}
			}
		}
	}
	private bool IsNumberActive(int value) {
		for (int i = 0; i < activeCount; i++) {
			if (activeNumbers [i] == value) {
				return true;
			}
		}
		return false; 
	}
	// Update is called once per frame
	void Update () {
		
	}
}
